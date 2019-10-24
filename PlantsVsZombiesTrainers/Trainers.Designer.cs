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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trainers));
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
            this.pidlabel = new System.Windows.Forms.Label();
            this.gname = new System.Windows.Forms.TextBox();
            this.reload = new System.Windows.Forms.Button();
            this.nocdtimer = new System.Windows.Forms.Timer(this.components);
            this.sunraintimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sunrain);
            this.tabPage1.Controls.Add(this.nocd);
            this.tabPage1.Controls.Add(this.editcoin);
            this.tabPage1.Controls.Add(this.coin);
            this.tabPage1.Controls.Add(this.sun);
            this.tabPage1.Controls.Add(this.editsun);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sunrain
            // 
            resources.ApplyResources(this.sunrain, "sunrain");
            this.sunrain.Name = "sunrain";
            this.sunrain.UseVisualStyleBackColor = true;
            this.sunrain.CheckedChanged += new System.EventHandler(this.sunrain_CheckedChanged);
            // 
            // nocd
            // 
            resources.ApplyResources(this.nocd, "nocd");
            this.nocd.Name = "nocd";
            this.nocd.UseVisualStyleBackColor = true;
            this.nocd.CheckedChanged += new System.EventHandler(this.nocd_CheckedChanged);
            // 
            // editcoin
            // 
            resources.ApplyResources(this.editcoin, "editcoin");
            this.editcoin.Name = "editcoin";
            this.editcoin.UseVisualStyleBackColor = true;
            this.editcoin.Click += new System.EventHandler(this.editcoin_Click);
            // 
            // coin
            // 
            resources.ApplyResources(this.coin, "coin");
            this.coin.Name = "coin";
            // 
            // sun
            // 
            resources.ApplyResources(this.sun, "sun");
            this.sun.Name = "sun";
            // 
            // editsun
            // 
            resources.ApplyResources(this.editsun, "editsun");
            this.editsun.Name = "editsun";
            this.editsun.UseVisualStyleBackColor = true;
            this.editsun.Click += new System.EventHandler(this.editsun_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.editadv);
            this.tabPage2.Controls.Add(this.adv);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // editadv
            // 
            resources.ApplyResources(this.editadv, "editadv");
            this.editadv.Name = "editadv";
            this.editadv.UseVisualStyleBackColor = true;
            this.editadv.Click += new System.EventHandler(this.editadv_Click);
            // 
            // adv
            // 
            resources.ApplyResources(this.adv, "adv");
            this.adv.Name = "adv";
            // 
            // pidlabel
            // 
            resources.ApplyResources(this.pidlabel, "pidlabel");
            this.pidlabel.Name = "pidlabel";
            // 
            // gname
            // 
            resources.ApplyResources(this.gname, "gname");
            this.gname.Name = "gname";
            // 
            // reload
            // 
            resources.ApplyResources(this.reload, "reload");
            this.reload.Name = "reload";
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
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.Controls.Add(this.reload);
            this.Controls.Add(this.gname);
            this.Controls.Add(this.pidlabel);
            this.Controls.Add(this.tabControl);
            this.Name = "Trainers";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
    }
}

