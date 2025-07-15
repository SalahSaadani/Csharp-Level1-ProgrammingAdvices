using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRESS_BAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            for (int i = 1 ; i <= 100; i++)
             {
                progressBar1.Value = i;
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    Thread.Sleep(500);
                    progressBar1.Value += 10;

                    label1.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100) + "%";

                    progressBar1.Refresh();
                    label1.Refresh();
                }
                else
                {
                    button1.Enabled = false;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
                progressBar1.Value = 0;
                label1.Text = "0%";
                button1.Enabled = true;
        }
    }
}
