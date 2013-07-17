using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedisTray
{
    public partial class FrmMain : Form
    {
        private Process _redisProcess;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnToggleServer_CheckedChanged(object sender, System.EventArgs e)
        {
            if (_redisProcess == null)
            {
                RedisProcessStart();
            }
        }

        private void RedisProcessStart()
        {
            var processStartInfo = new ProcessStartInfo
            {
                FileName               = @"C:\Users\moonpyk\Desktop\Dev\Redis\redis-server.exe",
                UseShellExecute        = false,
                CreateNoWindow         = true,
                RedirectStandardError  = true,
                RedirectStandardInput  = true,
                RedirectStandardOutput = true,
                StandardOutputEncoding = Encoding.UTF8,
                StandardErrorEncoding  = Encoding.UTF8,
            };

            _redisProcess = Process.Start(processStartInfo);

            _redisProcess.OutputDataReceived += RedisProcessOnOutputDataReceived;
            _redisProcess.ErrorDataReceived += RedisProcessOnOutputDataReceived;

            _redisProcess.BeginOutputReadLine();
            _redisProcess.BeginErrorReadLine();
        }

        private void RedisProcessClose()
        {
            if (_redisProcess != null)
            {
                _redisProcess.CancelErrorRead();
                _redisProcess.CancelOutputRead();
                _redisProcess.Kill();
                _redisProcess.Dispose();
            }
        }

        private void AppendRedisOutText(string t)
        {
            Invoke((MethodInvoker)delegate
            {
                if (string.IsNullOrWhiteSpace(t))
                {
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
            RedisProcessClose();
        }
    }
}
