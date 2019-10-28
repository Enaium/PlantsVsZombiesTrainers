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
            Memory.WriteMemoryValue(getSunBaseAddress(), gname.Text, int.Parse(sun.Text));
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

        public int getSunRainBaseAddress()
        {
            int baseaddress = Memory.ReadMemoryValue(getBaseAddress(), gname.Text);
            baseaddress = baseaddress + 0x868;
            baseaddress = Memory.ReadMemoryValue(baseaddress, gname.Text);
            baseaddress = baseaddress + 0x5550;
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

        public int getBossHpBaseAddress()
        { 
            int baseaddress = Memory.ReadMemoryValue(getBaseAddress(), gname.Text);
            baseaddress = baseaddress + 0x868;
            baseaddress = Memory.ReadMemoryValue(baseaddress,gname.Text);
            baseaddress = baseaddress + 0xa8;
            baseaddress = Memory.ReadMemoryValue(baseaddress,gname.Text);
            baseaddress = baseaddress + 0xc8;
            return baseaddress;
        }

        public int getFertilizerBaseAddress()
        {
            int baseaddress = Memory.ReadMemoryValue(getBaseAddress(), gname.Text);
            baseaddress = baseaddress + 0x94c;
            baseaddress = Memory.ReadMemoryValue(baseaddress, gname.Text);
            baseaddress = baseaddress + 0x224;
            return baseaddress;
        }

        public int getBugSprayBaseAddress()
        {
            int baseaddress = Memory.ReadMemoryValue(getBaseAddress(), gname.Text);
            baseaddress = baseaddress + 0x94c;
            baseaddress = Memory.ReadMemoryValue(baseaddress, gname.Text);
            baseaddress = baseaddress + 0x228;
            return baseaddress;
        }

        public int getChocolateBaseAddress()
        {
            int baseaddress = Memory.ReadMemoryValue(getBaseAddress(), gname.Text);
            baseaddress = baseaddress + 0x94c;
            baseaddress = Memory.ReadMemoryValue(baseaddress, gname.Text);
            baseaddress = baseaddress + 0x254;
            return baseaddress;
        }

        public int getTreeFoodBaseAddress()
        {
            int baseaddress = Memory.ReadMemoryValue(getBaseAddress(), gname.Text);
            baseaddress = baseaddress + 0x94c;
            baseaddress = Memory.ReadMemoryValue(baseaddress, gname.Text);
            baseaddress = baseaddress + 0x25c;
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
            bosshp.Text = Memory.ReadMemoryValue(getBossHpBaseAddress(),gname.Text).ToString();
            fertilizer.Text = (Memory.ReadMemoryValue(getFertilizerBaseAddress(), gname.Text) - 1000).ToString();
            bugspray.Text = (Memory.ReadMemoryValue(getBugSprayBaseAddress(), gname.Text) - 1000).ToString();
            chocolate.Text = (Memory.ReadMemoryValue(getChocolateBaseAddress(), gname.Text) - 1000).ToString();
            treefood.Text = (Memory.ReadMemoryValue(getTreeFoodBaseAddress(), gname.Text) - 1000).ToString();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            load();
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
            }
            else
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
            baseaddress = baseaddress + 0x15c;
            baseaddress = Memory.ReadMemoryValue(baseaddress, gname.Text);
            baseaddress = baseaddress + 0xc0;
            Memory.WriteMemoryValue(baseaddress, gname.Text, 1);

            baseaddress = Memory.ReadMemoryValue(getBaseAddress(), gname.Text);
            baseaddress = baseaddress + 0x868;
            baseaddress = Memory.ReadMemoryValue(baseaddress, gname.Text);
            baseaddress = baseaddress + 0x15c;
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



        private void sunrain_CheckedChanged(object sender, EventArgs e)
        {
            if (sunrain.Checked)
            {
                sunraintimer.Enabled = true;
            }
            else
            {
                sunraintimer.Enabled = false;
            }
        }

        private void sunraintimer_Tick(object sender, EventArgs e)
        {
            Memory.WriteMemoryValue(getSunRainBaseAddress(), gname.Text, 1);
        }

        private void editbosshp_Click(object sender, EventArgs e)
        {
            Memory.WriteMemoryValue(getBossHpBaseAddress(),gname.Text,int.Parse(bosshp.Text));
        }

        private void editfertilizer_Click(object sender, EventArgs e)
        {
            Memory.WriteMemoryValue(getFertilizerBaseAddress(),gname.Text,int.Parse(fertilizer.Text) + 1000);
        }

        private void editbugspray_Click(object sender, EventArgs e)
        {
            Memory.WriteMemoryValue(getBugSprayBaseAddress(), gname.Text, int.Parse(bugspray.Text) + 1000);
        }

        private void editchocolate_Click(object sender, EventArgs e)
        {
            Memory.WriteMemoryValue(getChocolateBaseAddress(), gname.Text, int.Parse(chocolate.Text) + 1000);
        }

        private void edittreefood_Click(object sender, EventArgs e)
        {
            Memory.WriteMemoryValue(getTreeFoodBaseAddress(), gname.Text, int.Parse(treefood.Text) + 1000);

        }
    }
}