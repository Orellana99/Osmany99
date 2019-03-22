using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmOSMANY : Form
    {

        int a, b, r;
        String Datos;

        public frmOSMANY()
        {
            InitializeComponent();
            textBox1.Text = " 0 ";
            textBox2.Text = " 0 ";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmOSMANY_Load(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }
         
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a - b;
            Datos = "RESULTADO" + r.ToString();

            label8.Text = Datos;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a / b;
            Datos = "RESULTADO" + r.ToString();

            label8.Text = Datos;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a + b;
            Datos = "RESULTADO" + r.ToString();

            label8.Text = Datos;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a * b;
            Datos = "RESULTADO" + r.ToString();

            label8.Text = Datos;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
