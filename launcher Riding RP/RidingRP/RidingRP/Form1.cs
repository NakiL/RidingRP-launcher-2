using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RidingRP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(("https://discord.gg/54j7Xs4"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("fivem://connect/5.9.161.189");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://top-serveurs.net/gta/riding-rp-wl");
        }
    }
}
