using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Form1 : Form
    {

        int splitsecond = 0;
        int second = 0;
        int minute = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "START";
            button2.Text = "RESET";
        }

        int status = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (status ==  0)
            {
                button1.Text = "PAUSE";
                status = 1;
                timer1.Start();
            }

            else if (status == 1)
            {
                button1.Text = "START";
                status = 0;
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (splitsecond == 60)
            {
                splitsecond = 0;
                second++;
            }

            if (second == 60)
            {
                splitsecond = 0;
                second = 0;
                minute++;
            }

            label1.Text = String.Format("{0:D2}", minute) + ":" + String.Format("{0:D2}", second) + ":" + String.Format("{0:D2}", splitsecond);
            splitsecond++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            minute = 0;
            second = 0;
            splitsecond = 0;

            label1.Text = "00:00:00";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
