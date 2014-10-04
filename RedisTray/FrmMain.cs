using RedisTray.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace RedisTray
{
    public partial class FrmMain : Form
    {
        private readonly Icon _iconNotStarted = Icon.ExtractAssociatedIcon(Assembly.GetCallingAssembly().Location);
        private readonly RedisProcess _redisProcess = new RedisProcess();
        private readonly StringBuilder _buffer = new StringBuilder();

        public FrmMain()
        {
            InitializeComponent();

            notifyIcon.Icon = Icon = _iconNotStarted;

            _redisProcess.OutputDataReceived += RedisProcessOnOutputDataReceived;
            _redisProcess.ErrorDataReceived  += RedisProcessOnOutputDataReceived;

            _redisProcess.PropertyChanged += (sender, args) => SafeInvoke((MethodInvoker)delegate
            {
                if (args.PropertyName == "IsRunning")
                {
                    btnToggleServer.Checked = _redisProcess.IsRunning;
                    SetRedisStatus(_redisProcess.IsRunning);
                }

                if (
                    _redisProcess.IsRunning &&
                    (args.PropertyName == "PortNumber" || args.PropertyName == "RedisVersion"))
                {
                    PutRedisInfo();
                }
            });
        }

        private static Settings Settings
        {
            get
            {
                return Settings.Default;
            }
        }

        private void PutRedisInfo()
        {
            var t = string.Format(
                "Redis {1} listening on port {0}",
                _redisProcess.PortNumber,
                _redisProcess.RedisVersion
            );

            toolStripStatusLabel.Text = t;

            notifyIcon.Text = string.Format("RedisTray - {0}", t);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (_buffer.Length > 0)
            {
                txtRedisOut.AppendText(_buffer.ToString());
                _buffer.Clear();
            }

            AutoStartIfConfigured();
        }

        public void AutoStartIfConfigured()
        {
            if (Settings.AutoStartRedis && !_redisProcess.IsRunning)
            {
                btnToggleServer.Checked = true;
            }
        }

        private void btnToggleServer_CheckedChanged(object sender, EventArgs e)
        {
            if (btnToggleServer.Checked)
            {
                _redisProcess.Start();
            }
            else
            {
                _redisProcess.Stop();
            }
        }

        public void SetRedisStatus(bool started)
        {
            if (started)
            {
                btnToggleServer.Image = Resources.control_stop_square;
                btnToggleServer.Text  = "Stop Redis";
                notifyIcon.Icon       = Icon = Resources.redis_tick;
                PutRedisInfo();
            }
            else
            {
                btnToggleServer.Image     = Resources.control;
                btnToggleServer.Text      = "Start Redis";
                notifyIcon.Icon           = Icon = _iconNotStarted;
                toolStripStatusLabel.Text = "";
                notifyIcon.Text           = "RedisTray";
            }
        }

        private void AppendRedisOutText(string t)
        {
            SafeInvoke((MethodInvoker)delegate
            {
                if (string.IsNullOrWhiteSpace(t))
                {
                    return;
                }
                if (!IsHandleCreated)
                {
                    _buffer.Append(t + Environment.NewLine);
                    return;
                }
                txtRedisOut.AppendText(t + Environment.NewLine);
            });
        }

        private void RedisProcessOnOutputDataReceived(object sender, DataReceivedEventArgs dataReceivedEventArgs)
        {
            AppendRedisOutText(dataReceivedEventArgs.Data);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
            {
                return;
            }
            e.Cancel = true;
            ToggleVisible();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            _redisProcess.ClearEventHandlers();
            _redisProcess.Stop();

            notifyIcon.Visible = Visible = false;
            Application.Exit();
        }

        private void hideWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleVisible();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ToggleVisible();
        }

        private void ToggleVisible()
        {
            Visible = !Visible;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Settings.Save();
        }

        private void btnBrowseRedis_Click(object sender, EventArgs e)
        {
            BrowseFile(_ => txtRedisPath.Text = _);
        }

        private void btnBrowseRedisCli_Click(object sender, EventArgs e)
        {
            BrowseFile(_ => txtRedisCliPath.Text = _);
        }

        private void btnBrowseRedisConfig_Click(object sender, EventArgs e)
        {
            BrowseFile(_ => txtRedisConfigPath.Text = _);
        }

        private void btnLunchRedisCli_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(
                    Settings.RedisCliPath,
                    string.Format("-p {0}", _redisProcess.PortNumber)
                ));
            }
            // ReSharper disable EmptyGeneralCatchClause
            catch (Exception) { }
            // ReSharper restore EmptyGeneralCatchClause
        }

        private void SafeInvoke(Delegate d)
        {
            if (IsHandleCreated)
            {
                Invoke(d);
            }
            else
            {
                d.DynamicInvoke(null);
            }
        }

        private void BrowseFile(Action<string> callback)
        {
            using (var o = new OpenFileDialog())
            {
                if (o.ShowDialog(this) == DialogResult.OK)
                {
                    callback(o.FileName);
                }
            }
        }
    }
}
