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
using RedisTray.Properties;

namespace RedisTray
{
    public partial class FrmMain : Form
    {
        private Process _redisProcess;

        public FrmMain()
        {
            InitializeComponent();

            tabRedisCli.Visible = tabOptions.Visible = false;
            Icon = notifyIcon.Icon = Resources.redistray;
        }

        private static Settings Settings
        {
            get
            {
                return Settings.Default;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (Settings.AutoStartRedis)
            {
                btnToggleServer.Checked = true;
            }
        }

        private void btnToggleServer_CheckedChanged(object sender, System.EventArgs e)
        {
            if (_redisProcess == null && btnToggleServer.Checked)
            {
                RedisProcessStart();
            }

            if (!btnToggleServer.Checked)
            {
                RedisProcessStop();
            }
        }

        public void SetRedisStatus(bool started)
        {
            if (started)
            {
                btnToggleServer.Image = Resources.control_stop_square;
                btnToggleServer.Text = "Stop Redis";
            }
            else
            {
                btnToggleServer.Image = Resources.control;
                btnToggleServer.Text = "Start Redis";
            }
        }

        private void RedisProcessStart()
        {
            if (_redisProcess != null)
            {
                return;
            }

            var processStartInfo = new ProcessStartInfo
            {
                FileName               = Settings.RedisServerPath,
                UseShellExecute        = false,
                CreateNoWindow         = true,
                RedirectStandardError  = true,
                RedirectStandardInput  = true,
                RedirectStandardOutput = true,
                StandardOutputEncoding = Encoding.UTF8,
                StandardErrorEncoding  = Encoding.UTF8,
            };

            _redisProcess = Process.Start(processStartInfo);
            _redisProcess.EnableRaisingEvents = true;

            SetRedisStatus(true);

            _redisProcess.OutputDataReceived += RedisProcessOnOutputDataReceived;
            _redisProcess.ErrorDataReceived += RedisProcessOnOutputDataReceived;
            _redisProcess.Exited += (sender, args) => Invoke((MethodInvoker)delegate
            {
                btnToggleServer.Checked = false;
            });
            _redisProcess.BeginOutputReadLine();
            _redisProcess.BeginErrorReadLine();
        }

        private void RedisProcessStop()
        {
            if (_redisProcess == null)
            {
                return;
            }

            _redisProcess.CancelErrorRead();
            _redisProcess.CancelOutputRead();
            
            if (!_redisProcess.HasExited)
            {
                _redisProcess.Kill();
                _redisProcess.Dispose();
            }
            
            _redisProcess = null;

            SetRedisStatus(false);
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
            RedisProcessStop();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hideWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleVisible();
        }

        private void ToggleVisible()
        {
            Visible = !Visible;
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ToggleVisible();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void BrowseExecutable_Click(object sender, EventArgs e)
        {

        }
    }
}
