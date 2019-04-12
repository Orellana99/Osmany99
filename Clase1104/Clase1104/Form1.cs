using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase1104
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
       Form1 hijo = new Form1();
       hijo.MiParents = this;
       hijo.Show();
       //hijo. 


        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form llamar in MDIParent1.MDI)
            {

                estado = true;

            }
        }
    }
}
