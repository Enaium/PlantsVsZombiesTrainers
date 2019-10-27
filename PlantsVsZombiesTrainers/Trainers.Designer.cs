namespace PlantsVsZombiesTrainers
{
    partial class Trainers
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sunrain = new System.Windows.Forms.CheckBox();
            this.nocd = new System.Windows.Forms.CheckBox();
            this.editcoin = new System.Windows.Forms.Button();
            this.coin = new System.Windows.Forms.TextBox();
            this.sun = new System.Windows.Forms.TextBox();
            this.editsun = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.editadv = new System.Windows.Forms.Button();
            this.adv = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.editbosshp = new System.Windows.Forms.Button();
            this.bosshp = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pidlabel = new System.Windows.Forms.Label();
            this.gname = new System.Windows.Forms.TextBox();
            this.reload = new System.Windows.Forms.Button();
            this.nocdtimer = new System.Windows.Forms.Timer(this.components);
            this.sunraintimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(619, 303);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sunrain);
            this.tabPage1.Controls.Add(this.nocd);
            this.tabPage1.Controls.Add(this.editcoin);
            this.tabPage1.Controls.Add(this.coin);
            this.tabPage1.Controls.Add(this.sun);
            this.tabPage1.Controls.Add(this.editsun);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(611, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basics";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sunrain
            // 
            this.sunrain.AutoSize = true;
            this.sunrain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sunrain.Location = new System.Drawing.Point(112, 74);
            this.sunrain.Name = "sunrain";
            this.sunrain.Size = new System.Drawing.Size(85, 19);
            this.sunrain.TabIndex = 6;
            this.sunrain.Text = "SunRain";
            this.sunrain.UseVisualStyleBackColor = true;
            this.sunrain.CheckedChanged += new System.EventHandler(this.sunrain_CheckedChanged);
            // 
            // nocd
            // 
            this.nocd.AutoSize = true;
            this.nocd.Location = new System.Drawing.Point(6, 74);
            this.nocd.Name = "nocd";
            this.nocd.Size = new System.Drawing.Size(61, 19);
            this.nocd.TabIndex = 5;
            this.nocd.Text = "NoCD";
            this.nocd.UseVisualStyleBackColor = true;
            this.nocd.CheckedChanged += new System.EventHandler(this.nocd_CheckedChanged);
            // 
            // editcoin
            // 
            this.editcoin.Location = new System.Drawing.Point(112, 37);
            this.editcoin.Name = "editcoin";
            this.editcoin.Size = new System.Drawing.Size(100, 31);
            this.editcoin.TabIndex = 4;
            this.editcoin.Text = "EditCoin";
            this.editcoin.UseVisualStyleBackColor = true;
            this.editcoin.Click += new System.EventHandler(this.editcoin_Click);
            // 
            // coin
            // 
            this.coin.Location = new System.Drawing.Point(112, 6);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(100, 25);
            this.coin.TabIndex = 3;
            // 
            // sun
            // 
            this.sun.Location = new System.Drawing.Point(6, 6);
            this.sun.Name = "sun";
            this.sun.Size = new System.Drawing.Size(100, 25);
            this.sun.TabIndex = 2;
            // 
            // editsun
            // 
            this.editsun.Location = new System.Drawing.Point(6, 37);
            this.editsun.Name = "editsun";
            this.editsun.Size = new System.Drawing.Size(100, 31);
            this.editsun.TabIndex = 1;
            this.editsun.Text = "EditSun";
            this.editsun.UseVisualStyleBackColor = true;
            this.editsun.Click += new System.EventHandler(this.editsun_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.editadv);
            this.tabPage2.Controls.Add(this.adv);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(611, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Page";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // editadv
            // 
            this.editadv.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.editadv.Location = new System.Drawing.Point(6, 37);
            this.editadv.Name = "editadv";
            this.editadv.Size = new System.Drawing.Size(100, 23);
            this.editadv.TabIndex = 4;
            this.editadv.Text = "EditAdvPage";
            this.editadv.UseVisualStyleBackColor = true;
            this.editadv.Click += new System.EventHandler(this.editadv_Click);
            // 
            // adv
            // 
            this.adv.Location = new System.Drawing.Point(6, 6);
            this.adv.Name = "adv";
            this.adv.Size = new System.Drawing.Size(100, 25);
            this.adv.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.editbosshp);
            this.tabPage3.Controls.Add(this.bosshp);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(611, 274);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Zombies";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // editbosshp
            // 
            this.editbosshp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.editbosshp.Location = new System.Drawing.Point(6, 37);
            this.editbosshp.Name = "editbosshp";
            this.editbosshp.Size = new System.Drawing.Size(100, 31);
            this.editbosshp.TabIndex = 2;
            this.editbosshp.Text = "EditBossHP";
            this.editbosshp.UseVisualStyleBackColor = true;
            this.editbosshp.Click += new System.EventHandler(this.editbosshp_Click);
            // 
            // bosshp
            // 
            this.bosshp.Location = new System.Drawing.Point(6, 6);
            this.bosshp.Name = "bosshp";
            this.bosshp.Size = new System.Drawing.Size(100, 25);
            this.bosshp.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(611, 274);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Garden";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pidlabel
            // 
            this.pidlabel.AutoSize = true;
            this.pidlabel.Location = new System.Drawing.Point(522, 329);
            this.pidlabel.Name = "pidlabel";
            this.pidlabel.Size = new System.Drawing.Size(0, 15);
            this.pidlabel.TabIndex = 2;
            // 
            // gname
            // 
            this.gname.Location = new System.Drawing.Point(12, 326);
            this.gname.Name = "gname";
            this.gname.Size = new System.Drawing.Size(100, 25);
            this.gname.TabIndex = 3;
            // 
            // reload
            // 
            this.reload.Location = new System.Drawing.Point(118, 321);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(100, 31);
            this.reload.TabIndex = 4;
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // nocdtimer
            // 
            this.nocdtimer.Interval = 1000;
            this.nocdtimer.Tick += new System.EventHandler(this.nocdtimer_Tick);
            // 
            // sunraintimer
            // 
            this.sunraintimer.Interval = 300;
            this.sunraintimer.Tick += new System.EventHandler(this.sunraintimer_Tick);
            // 
            // Trainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(643, 355);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.gname);
            this.Controls.Add(this.pidlabel);
            this.Controls.Add(this.tabControl);
            this.Name = "Trainers";
            this.Text = "PvZ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox sun;
        private System.Windows.Forms.Button editsun;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label pidlabel;
        private System.Windows.Forms.TextBox gname;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.Button editcoin;
        private System.Windows.Forms.TextBox coin;
        private System.Windows.Forms.Button editadv;
        private System.Windows.Forms.TextBox adv;
        private System.Windows.Forms.CheckBox nocd;
        private System.Windows.Forms.Timer nocdtimer;
        private System.Windows.Forms.CheckBox sunrain;
        private System.Windows.Forms.Timer sunraintimer;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button editbosshp;
        private System.Windows.Forms.TextBox bosshp;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

