using RedisTray.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace RedisTray
{
    public partial class FrmMain : Form
    {
        private readonly RedisProcess _redisProcess = new RedisProcess();

        public FrmMain()
        {
            InitializeComponent();

           notifyIcon.Icon = Icon = 
               Icon.ExtractAssociatedIcon(Assembly.GetCallingAssembly().Location);

            _redisProcess.OutputDataReceived += RedisProcessOnOutputDataReceived;
            _redisProcess.ErrorDataReceived += RedisProcessOnOutputDataReceived;

            _redisProcess.PropertyChanged += (sender, args) => Invoke((MethodInvoker)delegate
            {
                if (args.PropertyName == "IsRunning")
                {
                    btnToggleServer.Checked = _redisProcess.IsRunning;
                    SetRedisStatus(_redisProcess.IsRunning);
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
                btnToggleServer.Text = "Stop Redis";
            }
            else
            {
                btnToggleServer.Image = Resources.control;
                btnToggleServer.Text = "Start Redis";
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

        private void BrowseExecutable_Click(object sender, EventArgs e)
        {

        }
    }
}
