using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using fivemLuncher;

namespace SiriusRP
{
    public partial class Form1 : Form
    {
        ayarlar SiriusRP = new ayarlar();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ts3server://194.62.55.146?port=9001");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SiriusRP.steamidgirformu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SiriusRP.linkac("https://discordapp.com/channels/697368139154849822/697368140295831596/699597236874641538");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SiriusRP.linkac("https://discordapp.com/channels/697368139154849822/697368139750703128/697388959445286943");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SiriusRP.linkac("https://discordapp.com/channels/697368139154849822/697368139905630253/699597113658441768");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SiriusRP.linkac("https://discord.gg/2XH8UTK");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SiriusRP.luncherozelgiris("55e945dc629a0a");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SiriusRP.kapatProgrami();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sayi.Text = SiriusRP.onlinekackisi("55e945dc629a0a");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
