using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase0204
{
    public partial class Form1 : Form
    {
        Extra fr1 = new Extra();
        public Form1()
        {
            InitializeComponent();

            progressBar2.Maximum = 100;
            progressBar2.Minimum = 0;
            progressBar2.Step = 4;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i=0; i <= 24; i++) {
                progressBar2.PerformStep();
                this.Hide();

            }
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 24; i++)
            {
                progressBar2.PerformStep();
              //  fr1.Show();
              //  this.Hide();
                button4.BackColor = Color.Green;
                timer1.Interval = 3000;
                timer1.Enabled = true;
 


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (timer2. )
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button4.BackColor = Color.Green;
            timer1.Interval = 3000;
            timer1.Enabled = true;
 
                
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Extra frm = new Extra();
            frm.Show();
            this.Hide();
        }
    }
}
