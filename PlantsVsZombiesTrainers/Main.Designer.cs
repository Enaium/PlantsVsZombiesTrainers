namespace PlantsVsZombiesTrainers
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 312);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.editcoin);
            this.tabPage1.Controls.Add(this.coin);
            this.tabPage1.Controls.Add(this.sun);
            this.tabPage1.Controls.Add(this.editsun);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(612, 283);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "简单";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // editcoin
            // 
            this.editcoin.Location = new System.Drawing.Point(112, 37);
            this.editcoin.Name = "editcoin";
            this.editcoin.Size = new System.Drawing.Size(100, 31);
            this.editcoin.TabIndex = 4;
            this.editcoin.Text = "修改币";
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
            this.editsun.Text = "修改阳光";
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
            this.tabPage2.Size = new System.Drawing.Size(612, 283);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "关卡";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // editadv
            // 
            this.editadv.Location = new System.Drawing.Point(6, 37);
            this.editadv.Name = "editadv";
            this.editadv.Size = new System.Drawing.Size(100, 23);
            this.editadv.TabIndex = 4;
            this.editadv.Text = "修改冒险";
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
            // pidlabel
            // 
            this.pidlabel.AutoSize = true;
            this.pidlabel.Location = new System.Drawing.Point(522, 329);
            this.pidlabel.Name = "pidlabel";
            this.pidlabel.Size = new System.Drawing.Size(39, 15);
            this.pidlabel.TabIndex = 2;
            this.pidlabel.Text = "PID:";
            // 
            // gname
            // 
            this.gname.Location = new System.Drawing.Point(12, 326);
            this.gname.Name = "gname";
            this.gname.Size = new System.Drawing.Size(100, 25);
            this.gname.TabIndex = 3;
            this.gname.Text = "popcapgame1";
            // 
            // reload
            // 
            this.reload.Location = new System.Drawing.Point(118, 321);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(100, 31);
            this.reload.TabIndex = 4;
            this.reload.Text = "ReLoad";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(654, 355);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.gname);
            this.Controls.Add(this.pidlabel);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "PlantsVsZombiesTrainers-By Lightcolour";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
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
    }
}

