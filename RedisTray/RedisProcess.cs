using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using RedisTray.Annotations;
using RedisTray.Properties;

namespace RedisTray
{
    public class RedisProcess : INotifyPropertyChanged
    {
        private static readonly Regex PortReadyRegex = new Regex(
            @"the server is now ready to accept connections on port (\d+)",
            RegexOptions.Compiled | RegexOptions.IgnoreCase
        );

        private static readonly Regex RedisVersionRegex = new Regex(
            @"server started, redis version ([0-9.]+)",
            RegexOptions.Compiled | RegexOptions.IgnoreCase
        );

        private bool _isRunning;
        private int _portNumber = 6379;
        private Process _proc;
        private Version _redisVersion = new Version(0, 0);

        private static Settings Settings
        {
            get
            {
                return Settings.Default;
            }
        }

        public bool IsRunning
        {
            get { return _isRunning; }
            private set
            {
                if (value.Equals(_isRunning)) return;
                _isRunning = value;
                OnPropertyChanged();
            }
        }

        public int PortNumber
        {
            get { return _portNumber; }
            private set
            {
                if (value == _portNumber) return;
                _portNumber = value;
                OnPropertyChanged();
            }
        }

        public Version RedisVersion
        {
            get { return _redisVersion; }
            set
            {
                if (Equals(value, _redisVersion)) return;
                _redisVersion = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event DataReceivedEventHandler ErrorDataReceived;
        public event DataReceivedEventHandler OutputDataReceived;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void Stop()
        {
            if (!IsRunning)
            {
                return;
            }

            try
            {
                using (var sock = new TcpClient())
                {
                    sock.Connect(new IPEndPoint(IPAddress.Loopback, PortNumber));
                    var s = sock.GetStream();

                    var command = Encoding.ASCII.GetBytes("SHUTDOWN\r\n");
                    s.Write(command, 0, command.Length);
                    s.Close(1000);
                }
            }
            catch (Exception)
            {
                Kill();
            }
        }

        public void Start()
        {
            if (IsRunning)
            {
                return;
            }

            var redisArgs = string.Empty;

            if (!string.IsNullOrWhiteSpace(Settings.RedisServerConfigPath) &&
                File.Exists(Settings.RedisServerConfigPath))
            {
                redisArgs = Settings.RedisServerConfigPath;
            }

            _proc = new Process
            {
                EnableRaisingEvents = true,
                StartInfo = new ProcessStartInfo
                {
                    FileName               = Settings.RedisServerPath,
                    UseShellExecute        = false,
                    CreateNoWindow         = true,
                    RedirectStandardError  = true,
                    RedirectStandardInput  = true,
                    RedirectStandardOutput = true,
                    StandardOutputEncoding = Encoding.UTF8,
                    StandardErrorEncoding  = Encoding.UTF8,
                    Arguments              = redisArgs,
                }
            };

            _proc.Exited += delegate
            {
                IsRunning = false;
                Cleanup();
            };

            _proc.ErrorDataReceived += delegate(object sender, DataReceivedEventArgs args)
            {
                var handler = ErrorDataReceived;
                if (handler != null)
                {
                    handler(this, args);
                }
            };

            _proc.OutputDataReceived += delegate(object sender, DataReceivedEventArgs args)
            {
                var handler = OutputDataReceived;
                if (handler != null)
                {
                    handler(this, args);
                }

                OnDataReceived(args);
            };

            try
            {
                IsRunning = _proc.Start();
            }
            // ReSharper disable EmptyGeneralCatchClause
            catch (Exception)
            {
                return;
            }
            // ReSharper restore EmptyGeneralCatchClause

            _proc.BeginErrorReadLine();
            _proc.BeginOutputReadLine();
        }

        protected virtual void OnDataReceived(DataReceivedEventArgs args)
        {
            if (string.IsNullOrWhiteSpace(args.Data))
            {
                return;
            }

            var m = PortReadyRegex.Match(args.Data);
            if (m.Success)
            {
                PortNumber = int.Parse(m.Groups[1].Value);
            }

            m = RedisVersionRegex.Match(args.Data);

            if (m.Success)
            {
                Version parsed;
                if (Version.TryParse(m.Groups[1].Value, out parsed))
                {
                    RedisVersion = parsed;
                }
            }
        }

        public void Kill()
        {
            if (!IsRunning || _proc == null)
            {
                return;
            }

            if (_proc.HasExited)
            {
                return;
            }

            _proc.Kill();
            IsRunning = false;
            Cleanup();
        }

        private void Cleanup()
        {
            _proc.Dispose();
            _proc = null;
        }

        public void ClearEventHandlers()
        {
            ErrorDataReceived = OutputDataReceived = null;
            PropertyChanged   = null;
        }
    }
}
