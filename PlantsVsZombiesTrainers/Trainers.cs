using PlantsVsZombiesTool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantsVsZombiesTrainers
{
    public partial class Trainers : Form
    {
        public int PID = 0;
        public Trainers()
        {
            InitializeComponent();
        }

        private void editsun_Click(object sender, EventArgs e)
        {
            Memory.WriteMemoryValue(getSunBaseAddress(), gname.Text,int.Parse(sun.Text));
        }

        private void editcoin_Click(object sender, EventArgs e)
        {
            Memory.WriteMemoryValue(getCoinBaseAddress(), gname.Text, int.Parse(coin.Text));

        }

        private void editadv_Click(object sender, EventArgs e)
        {
            Memory.WriteMemoryValue(getAdvPageBaseAddress(), gname.Text, int.Parse(adv.Text));
        }

        public int getSunBaseAddress() 
        {
            int baseaddress = Memory.ReadMemoryValue(getBaseAddress(), gname.Text);
            baseaddress = baseaddress + 0x868;
            baseaddress = Memory.ReadMemoryValue(baseaddress, gname.Text);
            baseaddress = baseaddress + 0x5578;
            return baseaddress;
        }

        public int getCoinBaseAddress()
        {
            int baseaddress = Memory.ReadMemoryValue(getBaseAddress(), gname.Text);
            baseaddress = baseaddress + 0x94c;
            baseaddress = Memory.ReadMemoryValue(baseaddress, gname.Text);
            baseaddress = baseaddress + 0x54;
            return baseaddress;
        }

        public int getAdvPageBaseAddress()
        {
            int baseaddress = Memory.ReadMemoryValue(getBaseAddress(), gname.Text);
            baseaddress = baseaddress + 0x94c;
            baseaddress = Memory.ReadMemoryValue(baseaddress, gname.Text);
            baseaddress = baseaddress + 0x50;
            return baseaddress;
        }



        private void Main_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load() 
        {
            PID = Memory.GetPidByProcessName(gname.Text);
            pidlabel.Text = "PID:" + PID;
            sun.Text = Memory.ReadMemoryValue(getSunBaseAddress(), gname.Text).ToString();
            coin.Text = Memory.ReadMemoryValue(getCoinBaseAddress(), gname.Text).ToString();
            adv.Text = Memory.ReadMemoryValue(getAdvPageBaseAddress(), gname.Text).ToString();
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en");
            ApplyResource();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            load();
        }

        private void ApplyResource()
        {
            System.ComponentModel.ComponentResourceManager res = new ComponentResourceManager(typeof(Trainers));
            foreach (Control ctl in Controls)
            {
                res.ApplyResources(ctl, ctl.Name);
            }
            this.ResumeLayout(false);
            this.PerformLayout();
            res.ApplyResources(this, "$this");
        }

        public int getBaseAddress() 
        {
            return 0x00731CDC;
        }

        private void nocd_CheckedChanged(object sender, EventArgs e)
        {
            if (nocd.Checked)
            {
                nocdtimer.Enabled = true;
            }else
            {
                nocdtimer.Enabled = false;
            }
        }

        private void nocdtimer_Tick(object sender, EventArgs e)
        {
            int baseaddress = 0;
            baseaddress = Memory.ReadMemoryValue(getBaseAddress(), gname.Text);
            baseaddress = baseaddress + 0x868;
            baseaddress = Memory.ReadMemoryValue(baseaddress, gname.Text);
            baseaddress = baseaddress + 0x15c;
            baseaddress = Memory.ReadMemoryValue(baseaddress, gname.Text);
            baseaddress = baseaddress + 0x70;
            Memory.WriteMemoryValue(baseaddress, gname.Text, 1);

            baseaddress = Memory.ReadMemoryValue(getBaseAddress(), gname.Text);
            baseaddress = baseaddress + 0x868;
            baseaddress = Memory.ReadMemoryValue(baseaddress, gname.Text);
            baseaddress = baseaddress + 0xc0;
            baseaddress = Memory.ReadMemoryValue(baseaddress, gname.Text);
            baseaddress = baseaddress + 0x110;
            Memory.WriteMemoryValue(baseaddress, gname.Text, 1);

            baseaddress = Memory.ReadMemoryValue(getBaseAddress(), gname.Text);
            baseaddress = baseaddress + 0x868;
            baseaddress = Memory.ReadMemoryValue(baseaddress, gname.Text);
            baseaddress = baseaddress + 0x15c;
            baseaddress = Memory.ReadMemoryValue(baseaddress, gname.Text);
            baseaddress = baseaddress + 0x160;
            Memory.WriteMemoryValue(baseaddress, gname.Text, 1);

            baseaddress = Memory.ReadMemoryValue(getBaseAddress(), gname.Text);
            baseaddress = baseaddress + 0x868;
            baseaddress = Memory.ReadMemoryValue(baseaddress, gname.Text);
            baseaddress = baseaddress + 0x15c;
            baseaddress = Memory.ReadMemoryValue(baseaddress, gname.Text);
            baseaddress = baseaddress + 0x1b0;
            Memory.WriteMemoryValue(baseaddress, gname.Text, 1);

            baseaddress = Memory.ReadMemoryValue(getBaseAddress(), gname.Text);
            baseaddress = baseaddress + 0x868;
            baseaddress = Memory.ReadMemoryValue(baseaddress, gname.Text);
            baseaddress = baseaddress + 0x15c;
            baseaddress = Memory.ReadMemoryValue(baseaddress, gname.Text);
            baseaddress = baseaddress + 0x200;
            Memory.WriteMemoryValue(baseaddress, gname.Text, 1);
        }
    }
}
