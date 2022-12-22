namespace MCPacker
{
    partial class MCPacker
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MCPacker));
            this.qwq = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ilaunchercb = new System.Windows.Forms.CheckBox();
            this.launchernamebox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.verl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.verbox = new System.Windows.Forms.TextBox();
            this.ilistgroup = new System.Windows.Forms.GroupBox();
            this.ilistpath = new System.Windows.Forms.TextBox();
            this.ilistsavebtn = new System.Windows.Forms.Button();
            this.ilistloadbtn = new System.Windows.Forms.Button();
            this.ilistbox = new System.Windows.Forms.TextBox();
            this.useworkfloderbox = new System.Windows.Forms.CheckBox();
            this.intstartbtn = new System.Windows.Forms.Button();
            this.iwayname = new System.Windows.Forms.Label();
            this.iwayselector = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.delsvrdatbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.delcrptbtn = new System.Windows.Forms.Button();
            this.dellogsbtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.taskprog = new System.Windows.Forms.ToolStripProgressBar();
            this.task = new System.Windows.Forms.ToolStripStatusLabel();
            this.bworkerzip = new System.ComponentModel.BackgroundWorker();
            this.turntogh = new System.Windows.Forms.Button();
            this.pkgnamebox = new System.Windows.Forms.TextBox();
            this.pkgnamel = new System.Windows.Forms.Label();
            this.qwq.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ilistgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iwayselector)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qwq
            // 
            this.qwq.Controls.Add(this.tabPage1);
            this.qwq.Controls.Add(this.tabPage2);
            this.qwq.Controls.Add(this.tabPage3);
            this.qwq.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qwq.Location = new System.Drawing.Point(13, 12);
            this.qwq.Name = "qwq";
            this.qwq.SelectedIndex = 0;
            this.qwq.Size = new System.Drawing.Size(688, 213);
            this.qwq.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pkgnamel);
            this.tabPage1.Controls.Add(this.pkgnamebox);
            this.tabPage1.Controls.Add(this.ilaunchercb);
            this.tabPage1.Controls.Add(this.launchernamebox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.verl);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.verbox);
            this.tabPage1.Controls.Add(this.ilistgroup);
            this.tabPage1.Controls.Add(this.useworkfloderbox);
            this.tabPage1.Controls.Add(this.intstartbtn);
            this.tabPage1.Controls.Add(this.iwayname);
            this.tabPage1.Controls.Add(this.iwayselector);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(680, 187);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "内置方法";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ilaunchercb
            // 
            this.ilaunchercb.AutoSize = true;
            this.ilaunchercb.Location = new System.Drawing.Point(89, 114);
            this.ilaunchercb.Name = "ilaunchercb";
            this.ilaunchercb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ilaunchercb.Size = new System.Drawing.Size(84, 16);
            this.ilaunchercb.TabIndex = 11;
            this.ilaunchercb.Text = "包含启动器";
            this.ilaunchercb.UseVisualStyleBackColor = true;
            this.ilaunchercb.CheckedChanged += new System.EventHandler(this.ilaunchercb_CheckedChanged);
            // 
            // launchernamebox
            // 
            this.launchernamebox.Enabled = false;
            this.launchernamebox.Location = new System.Drawing.Point(179, 111);
            this.launchernamebox.Name = "launchernamebox";
            this.launchernamebox.Size = new System.Drawing.Size(100, 21);
            this.launchernamebox.TabIndex = 10;
            this.launchernamebox.Text = ".\\launcher.exe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(150, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "上一个构建:";
            // 
            // verl
            // 
            this.verl.AutoSize = true;
            this.verl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.verl.Location = new System.Drawing.Point(218, 139);
            this.verl.Name = "verl";
            this.verl.Size = new System.Drawing.Size(53, 12);
            this.verl.TabIndex = 8;
            this.verl.Text = "[------]";
            this.verl.Click += new System.EventHandler(this.verl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ver";
            // 
            // verbox
            // 
            this.verbox.Location = new System.Drawing.Point(179, 154);
            this.verbox.Name = "verbox";
            this.verbox.Size = new System.Drawing.Size(100, 21);
            this.verbox.TabIndex = 6;
            this.verbox.TextChanged += new System.EventHandler(this.verbox_TextChanged);
            // 
            // ilistgroup
            // 
            this.ilistgroup.Controls.Add(this.ilistpath);
            this.ilistgroup.Controls.Add(this.ilistsavebtn);
            this.ilistgroup.Controls.Add(this.ilistloadbtn);
            this.ilistgroup.Controls.Add(this.ilistbox);
            this.ilistgroup.Location = new System.Drawing.Point(285, 6);
            this.ilistgroup.Name = "ilistgroup";
            this.ilistgroup.Size = new System.Drawing.Size(389, 175);
            this.ilistgroup.TabIndex = 4;
            this.ilistgroup.TabStop = false;
            this.ilistgroup.Text = "忽略列表";
            // 
            // ilistpath
            // 
            this.ilistpath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ilistpath.Location = new System.Drawing.Point(128, 20);
            this.ilistpath.Name = "ilistpath";
            this.ilistpath.ReadOnly = true;
            this.ilistpath.Size = new System.Drawing.Size(255, 21);
            this.ilistpath.TabIndex = 3;
            this.ilistpath.Text = "----------直接编辑,或者打开.list----------";
            // 
            // ilistsavebtn
            // 
            this.ilistsavebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ilistsavebtn.Enabled = false;
            this.ilistsavebtn.Image = global::MCPacker.Properties.Resources.file;
            this.ilistsavebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ilistsavebtn.Location = new System.Drawing.Point(68, 47);
            this.ilistsavebtn.Name = "ilistsavebtn";
            this.ilistsavebtn.Size = new System.Drawing.Size(54, 24);
            this.ilistsavebtn.TabIndex = 2;
            this.ilistsavebtn.Text = "保存";
            this.ilistsavebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ilistsavebtn.UseVisualStyleBackColor = true;
            this.ilistsavebtn.Click += new System.EventHandler(this.ilistsavebtn_Click);
            // 
            // ilistloadbtn
            // 
            this.ilistloadbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ilistloadbtn.Image = global::MCPacker.Properties.Resources.floder;
            this.ilistloadbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ilistloadbtn.Location = new System.Drawing.Point(6, 20);
            this.ilistloadbtn.Name = "ilistloadbtn";
            this.ilistloadbtn.Size = new System.Drawing.Size(116, 21);
            this.ilistloadbtn.TabIndex = 1;
            this.ilistloadbtn.Text = "打开一个.list";
            this.ilistloadbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ilistloadbtn.UseVisualStyleBackColor = true;
            this.ilistloadbtn.Click += new System.EventHandler(this.ilistloadbtn_Click);
            // 
            // ilistbox
            // 
            this.ilistbox.Location = new System.Drawing.Point(128, 47);
            this.ilistbox.Multiline = true;
            this.ilistbox.Name = "ilistbox";
            this.ilistbox.Size = new System.Drawing.Size(255, 122);
            this.ilistbox.TabIndex = 0;
            this.ilistbox.Text = ".minecraft\\logs\r\n.minecraft\\crash-reports\r\n.minecraft\\launcher_profiles.json\r\n";
            // 
            // useworkfloderbox
            // 
            this.useworkfloderbox.AutoSize = true;
            this.useworkfloderbox.Checked = true;
            this.useworkfloderbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useworkfloderbox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.useworkfloderbox.Location = new System.Drawing.Point(7, 84);
            this.useworkfloderbox.Name = "useworkfloderbox";
            this.useworkfloderbox.Size = new System.Drawing.Size(167, 21);
            this.useworkfloderbox.TabIndex = 3;
            this.useworkfloderbox.Text = "使用工作文件夹模式(推荐)";
            this.useworkfloderbox.UseVisualStyleBackColor = true;
            this.useworkfloderbox.CheckedChanged += new System.EventHandler(this.useworkfloderbox_CheckedChanged);
            // 
            // intstartbtn
            // 
            this.intstartbtn.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intstartbtn.Image = global::MCPacker.Properties.Resources.doc;
            this.intstartbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.intstartbtn.Location = new System.Drawing.Point(6, 142);
            this.intstartbtn.Name = "intstartbtn";
            this.intstartbtn.Size = new System.Drawing.Size(66, 39);
            this.intstartbtn.TabIndex = 2;
            this.intstartbtn.Text = "GO";
            this.intstartbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.intstartbtn.UseVisualStyleBackColor = true;
            this.intstartbtn.Click += new System.EventHandler(this.intstartbtn_Click);
            // 
            // iwayname
            // 
            this.iwayname.AutoSize = true;
            this.iwayname.BackColor = System.Drawing.Color.Gray;
            this.iwayname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iwayname.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iwayname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iwayname.Location = new System.Drawing.Point(17, 46);
            this.iwayname.Name = "iwayname";
            this.iwayname.Size = new System.Drawing.Size(37, 23);
            this.iwayname.TabIndex = 1;
            this.iwayname.Text = "ZIP";
            this.iwayname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iwayselector
            // 
            this.iwayselector.BackColor = System.Drawing.SystemColors.ControlLight;
            this.iwayselector.LargeChange = 1;
            this.iwayselector.Location = new System.Drawing.Point(7, 7);
            this.iwayselector.Maximum = 5;
            this.iwayselector.Name = "iwayselector";
            this.iwayselector.Size = new System.Drawing.Size(272, 45);
            this.iwayselector.TabIndex = 0;
            this.iwayselector.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.iwayselector.Scroll += new System.EventHandler(this.iwayselector_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(169, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "-------------------";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(680, 187);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "外置脚本";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("得意黑", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "开发中qwq";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.turntogh);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.delsvrdatbtn);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.delcrptbtn);
            this.tabPage3.Controls.Add(this.dellogsbtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(680, 187);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "屑工具";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(7, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "By LithiumFish";
            // 
            // delsvrdatbtn
            // 
            this.delsvrdatbtn.Location = new System.Drawing.Point(7, 65);
            this.delsvrdatbtn.Name = "delsvrdatbtn";
            this.delsvrdatbtn.Size = new System.Drawing.Size(108, 23);
            this.delsvrdatbtn.TabIndex = 3;
            this.delsvrdatbtn.Text = "删除servers.dat";
            this.delsvrdatbtn.UseVisualStyleBackColor = true;
            this.delsvrdatbtn.Click += new System.EventHandler(this.delsvrdatbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MCPacker.Properties.Resources.GrooveBattle;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(550, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 139);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // delcrptbtn
            // 
            this.delcrptbtn.Location = new System.Drawing.Point(6, 35);
            this.delcrptbtn.Name = "delcrptbtn";
            this.delcrptbtn.Size = new System.Drawing.Size(109, 23);
            this.delcrptbtn.TabIndex = 1;
            this.delcrptbtn.Text = "删除崩溃报告";
            this.delcrptbtn.UseVisualStyleBackColor = true;
            this.delcrptbtn.Click += new System.EventHandler(this.delcrptbtn_Click);
            // 
            // dellogsbtn
            // 
            this.dellogsbtn.Location = new System.Drawing.Point(6, 6);
            this.dellogsbtn.Name = "dellogsbtn";
            this.dellogsbtn.Size = new System.Drawing.Size(109, 23);
            this.dellogsbtn.TabIndex = 0;
            this.dellogsbtn.Text = "删除日志文件夹";
            this.dellogsbtn.UseVisualStyleBackColor = true;
            this.dellogsbtn.Click += new System.EventHandler(this.dellogsbtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.status,
            this.taskprog,
            this.task});
            this.statusStrip1.Location = new System.Drawing.Point(0, 228);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(713, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel1.Text = "MCPacker-Dev";
            // 
            // status
            // 
            this.status.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(40, 17);
            this.status.Text = "[空闲]";
            // 
            // taskprog
            // 
            this.taskprog.Name = "taskprog";
            this.taskprog.Size = new System.Drawing.Size(100, 16);
            // 
            // task
            // 
            this.task.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(31, 17);
            this.task.Text = "[---]";
            // 
            // bworkerzip
            // 
            this.bworkerzip.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwokerzip_DoWork);
            // 
            // turntogh
            // 
            this.turntogh.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.turntogh.Location = new System.Drawing.Point(622, 151);
            this.turntogh.Name = "turntogh";
            this.turntogh.Size = new System.Drawing.Size(52, 23);
            this.turntogh.TabIndex = 5;
            this.turntogh.Text = "GitHub";
            this.turntogh.UseVisualStyleBackColor = true;
            this.turntogh.Click += new System.EventHandler(this.turntogh_Click);
            // 
            // pkgnamebox
            // 
            this.pkgnamebox.Location = new System.Drawing.Point(79, 154);
            this.pkgnamebox.Name = "pkgnamebox";
            this.pkgnamebox.Size = new System.Drawing.Size(65, 21);
            this.pkgnamebox.TabIndex = 12;
            this.pkgnamebox.Visible = false;
            // 
            // pkgnamel
            // 
            this.pkgnamel.AutoSize = true;
            this.pkgnamel.Location = new System.Drawing.Point(79, 136);
            this.pkgnamel.Name = "pkgnamel";
            this.pkgnamel.Size = new System.Drawing.Size(29, 12);
            this.pkgnamel.TabIndex = 13;
            this.pkgnamel.Text = "包名";
            this.pkgnamel.Visible = false;
            // 
            // MCPacker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 250);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.qwq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MCPacker";
            this.Text = "MCPacker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MCPacker_FormClosed);
            this.Load += new System.EventHandler(this.MCPacker_Load);
            this.qwq.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ilistgroup.ResumeLayout(false);
            this.ilistgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iwayselector)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl qwq;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label iwayname;
        private System.Windows.Forms.TrackBar iwayselector;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar taskprog;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button intstartbtn;
        private System.Windows.Forms.Button dellogsbtn;
        private System.Windows.Forms.Button delcrptbtn;
        private System.Windows.Forms.CheckBox useworkfloderbox;
        private System.Windows.Forms.GroupBox ilistgroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ilistbox;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStripStatusLabel task;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ilistloadbtn;
        private System.Windows.Forms.Button ilistsavebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox verbox;
        private System.Windows.Forms.Button delsvrdatbtn;
        private System.Windows.Forms.TextBox ilistpath;
        private System.Windows.Forms.Label verl;
        private System.ComponentModel.BackgroundWorker bworkerzip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ilaunchercb;
        private System.Windows.Forms.TextBox launchernamebox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button turntogh;
        private System.Windows.Forms.TextBox pkgnamebox;
        private System.Windows.Forms.Label pkgnamel;
    }
}

