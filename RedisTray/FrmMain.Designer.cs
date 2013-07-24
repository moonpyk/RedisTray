﻿namespace RedisTray
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabRedisServer = new System.Windows.Forms.TabPage();
            this.btnStartRedisCli = new System.Windows.Forms.Button();
            this.btnToggleServer = new System.Windows.Forms.CheckBox();
            this.txtRedisOut = new System.Windows.Forms.TextBox();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBrowseRedisConfig = new System.Windows.Forms.Button();
            this.txtRedisConfigPath = new System.Windows.Forms.TextBox();
            this.btnBrowseRedisCli = new System.Windows.Forms.Button();
            this.txtRedisCliPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRedisPath = new System.Windows.Forms.TextBox();
            this.btnBrowseRedis = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuStartCli = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.hideWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contextStartRedisCli = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabRedisServer.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextStartRedisCli,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(144, 54);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem1.Text = "&Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(661, 331);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(661, 377);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip);
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(661, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabRedisServer);
            this.tabControl.Controls.Add(this.tabOptions);
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(658, 325);
            this.tabControl.TabIndex = 0;
            // 
            // tabRedisServer
            // 
            this.tabRedisServer.Controls.Add(this.btnStartRedisCli);
            this.tabRedisServer.Controls.Add(this.btnToggleServer);
            this.tabRedisServer.Controls.Add(this.txtRedisOut);
            this.tabRedisServer.Location = new System.Drawing.Point(4, 22);
            this.tabRedisServer.Name = "tabRedisServer";
            this.tabRedisServer.Padding = new System.Windows.Forms.Padding(3);
            this.tabRedisServer.Size = new System.Drawing.Size(650, 299);
            this.tabRedisServer.TabIndex = 0;
            this.tabRedisServer.Text = "Redis";
            this.tabRedisServer.UseVisualStyleBackColor = true;
            // 
            // btnStartRedisCli
            // 
            this.btnStartRedisCli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartRedisCli.Image = global::RedisTray.Properties.Resources.terminal__arrow;
            this.btnStartRedisCli.Location = new System.Drawing.Point(595, 260);
            this.btnStartRedisCli.Name = "btnStartRedisCli";
            this.btnStartRedisCli.Size = new System.Drawing.Size(49, 36);
            this.btnStartRedisCli.TabIndex = 2;
            this.btnStartRedisCli.UseVisualStyleBackColor = true;
            this.btnStartRedisCli.Click += new System.EventHandler(this.btnLunchRedisCli_Click);
            // 
            // btnToggleServer
            // 
            this.btnToggleServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleServer.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnToggleServer.Image = global::RedisTray.Properties.Resources.control;
            this.btnToggleServer.Location = new System.Drawing.Point(6, 260);
            this.btnToggleServer.Name = "btnToggleServer";
            this.btnToggleServer.Size = new System.Drawing.Size(582, 36);
            this.btnToggleServer.TabIndex = 1;
            this.btnToggleServer.Text = "Start Redis";
            this.btnToggleServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnToggleServer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnToggleServer.UseVisualStyleBackColor = true;
            this.btnToggleServer.CheckedChanged += new System.EventHandler(this.btnToggleServer_CheckedChanged);
            // 
            // txtRedisOut
            // 
            this.txtRedisOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRedisOut.BackColor = System.Drawing.SystemColors.Window;
            this.txtRedisOut.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRedisOut.Location = new System.Drawing.Point(6, 6);
            this.txtRedisOut.Multiline = true;
            this.txtRedisOut.Name = "txtRedisOut";
            this.txtRedisOut.ReadOnly = true;
            this.txtRedisOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRedisOut.Size = new System.Drawing.Size(638, 248);
            this.txtRedisOut.TabIndex = 0;
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.btnSaveSettings);
            this.tabOptions.Controls.Add(this.tableLayoutPanel2);
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptions.Size = new System.Drawing.Size(650, 299);
            this.tabOptions.TabIndex = 2;
            this.tabOptions.Text = "Options";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSettings.Location = new System.Drawing.Point(537, 263);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(107, 30);
            this.btnSaveSettings.TabIndex = 9;
            this.btnSaveSettings.Text = "Save settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnBrowseRedisConfig, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtRedisConfigPath, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnBrowseRedisCli, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtRedisCliPath, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtRedisPath, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBrowseRedis, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBox1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.checkBox2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(638, 187);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // btnBrowseRedisConfig
            // 
            this.btnBrowseRedisConfig.Image = global::RedisTray.Properties.Resources.folder_horizontal_open;
            this.btnBrowseRedisConfig.Location = new System.Drawing.Point(611, 55);
            this.btnBrowseRedisConfig.Name = "btnBrowseRedisConfig";
            this.btnBrowseRedisConfig.Size = new System.Drawing.Size(24, 20);
            this.btnBrowseRedisConfig.TabIndex = 17;
            this.btnBrowseRedisConfig.UseVisualStyleBackColor = true;
            this.btnBrowseRedisConfig.Click += new System.EventHandler(this.btnBrowseRedisConfig_Click);
            // 
            // txtRedisConfigPath
            // 
            this.txtRedisConfigPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RedisTray.Properties.Settings.Default, "RedisServerConfigPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRedisConfigPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRedisConfigPath.Location = new System.Drawing.Point(136, 55);
            this.txtRedisConfigPath.Name = "txtRedisConfigPath";
            this.txtRedisConfigPath.ReadOnly = true;
            this.txtRedisConfigPath.Size = new System.Drawing.Size(469, 20);
            this.txtRedisConfigPath.TabIndex = 16;
            this.txtRedisConfigPath.Text = global::RedisTray.Properties.Settings.Default.RedisServerConfigPath;
            // 
            // btnBrowseRedisCli
            // 
            this.btnBrowseRedisCli.Image = global::RedisTray.Properties.Resources.folder_horizontal_open;
            this.btnBrowseRedisCli.Location = new System.Drawing.Point(611, 29);
            this.btnBrowseRedisCli.Name = "btnBrowseRedisCli";
            this.btnBrowseRedisCli.Size = new System.Drawing.Size(24, 20);
            this.btnBrowseRedisCli.TabIndex = 12;
            this.btnBrowseRedisCli.UseVisualStyleBackColor = true;
            this.btnBrowseRedisCli.Click += new System.EventHandler(this.btnBrowseRedisCli_Click);
            // 
            // txtRedisCliPath
            // 
            this.txtRedisCliPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RedisTray.Properties.Settings.Default, "RedisCliPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRedisCliPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRedisCliPath.Location = new System.Drawing.Point(136, 29);
            this.txtRedisCliPath.Name = "txtRedisCliPath";
            this.txtRedisCliPath.ReadOnly = true;
            this.txtRedisCliPath.Size = new System.Drawing.Size(469, 20);
            this.txtRedisCliPath.TabIndex = 11;
            this.txtRedisCliPath.Text = global::RedisTray.Properties.Settings.Default.RedisCliPath;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Redis client executable :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Redis server executable :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRedisPath
            // 
            this.txtRedisPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RedisTray.Properties.Settings.Default, "RedisServerPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRedisPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRedisPath.Location = new System.Drawing.Point(136, 3);
            this.txtRedisPath.Name = "txtRedisPath";
            this.txtRedisPath.ReadOnly = true;
            this.txtRedisPath.Size = new System.Drawing.Size(469, 20);
            this.txtRedisPath.TabIndex = 3;
            this.txtRedisPath.Text = global::RedisTray.Properties.Settings.Default.RedisServerPath;
            // 
            // btnBrowseRedis
            // 
            this.btnBrowseRedis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowseRedis.Image = global::RedisTray.Properties.Resources.folder_horizontal_open;
            this.btnBrowseRedis.Location = new System.Drawing.Point(611, 3);
            this.btnBrowseRedis.Name = "btnBrowseRedis";
            this.btnBrowseRedis.Size = new System.Drawing.Size(24, 20);
            this.btnBrowseRedis.TabIndex = 4;
            this.btnBrowseRedis.UseVisualStyleBackColor = true;
            this.btnBrowseRedis.Click += new System.EventHandler(this.btnBrowseRedis_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::RedisTray.Properties.Settings.Default.AutoStartRedis;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel2.SetColumnSpan(this.checkBox1, 3);
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RedisTray.Properties.Settings.Default, "AutoStartRedis", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(3, 104);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Auto start Redis";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = global::RedisTray.Properties.Settings.Default.StartHidden;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RedisTray.Properties.Settings.Default, "StartHidden", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.Location = new System.Drawing.Point(3, 81);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 17);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Start hidden";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Redis config file :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(661, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuStartCli,
            this.toolStripSeparator1,
            this.hideWindowToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripMenuStartCli
            // 
            this.toolStripMenuStartCli.Image = global::RedisTray.Properties.Resources.terminal__arrow;
            this.toolStripMenuStartCli.Name = "toolStripMenuStartCli";
            this.toolStripMenuStartCli.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.toolStripMenuStartCli.Size = new System.Drawing.Size(191, 22);
            this.toolStripMenuStartCli.Text = "Start redis-cli";
            this.toolStripMenuStartCli.Click += new System.EventHandler(this.btnLunchRedisCli_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // hideWindowToolStripMenuItem
            // 
            this.hideWindowToolStripMenuItem.Name = "hideWindowToolStripMenuItem";
            this.hideWindowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.hideWindowToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.hideWindowToolStripMenuItem.Text = "&Hide Window";
            this.hideWindowToolStripMenuItem.Click += new System.EventHandler(this.hideWindowToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(140, 6);
            // 
            // contextStartRedisCli
            // 
            this.contextStartRedisCli.Image = global::RedisTray.Properties.Resources.terminal__arrow;
            this.contextStartRedisCli.Name = "contextStartRedisCli";
            this.contextStartRedisCli.Size = new System.Drawing.Size(143, 22);
            this.contextStartRedisCli.Text = "Start redis-cli";
            this.contextStartRedisCli.Click += new System.EventHandler(this.btnLunchRedisCli_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 377);
            this.Controls.Add(this.toolStripContainer1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "RedisTray";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.contextMenuStrip.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabRedisServer.ResumeLayout(false);
            this.tabRedisServer.PerformLayout();
            this.tabOptions.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideWindowToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabRedisServer;
        private System.Windows.Forms.CheckBox btnToggleServer;
        private System.Windows.Forms.TextBox txtRedisOut;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnBrowseRedisCli;
        private System.Windows.Forms.TextBox txtRedisCliPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRedisPath;
        private System.Windows.Forms.Button btnBrowseRedis;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnBrowseRedisConfig;
        private System.Windows.Forms.TextBox txtRedisConfigPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button btnStartRedisCli;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuStartCli;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem contextStartRedisCli;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

