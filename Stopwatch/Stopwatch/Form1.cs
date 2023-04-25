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
        public Form1()
        {
            InitializeComponent();
        }

        private float Counter = 0;
        private float Seconds = 0;
        private int Minutes = 0;
        


        void CountTime()
        {
            if(Counter == 99)
            {
                if (Seconds == 59)
                {
                    if (Minutes == 59)
                    {
                        timer1.Enabled = false;
                    }
                    else
                    {
                        Minutes++;
                        Seconds = 0;
                    }
                }
                else
                {
                    Seconds++;
                    Counter = 0;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter++;
            CountTime();
            lblSeconds.Text = (Seconds+(Counter/100)).ToString();
            lblMinutes.Text = Minutes.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

        }

        string GetTime()
        {
            return Minutes.ToString() + ":" + (Seconds + Counter / 100).ToString();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            lblLabs.Text += GetTime();
            lblLabs.Text += Environment.NewLine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Minutes = 0;
            Seconds = 0;
            Counter = 0;
        }
    }
}
