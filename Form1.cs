using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifthQuestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Roots r = new Roots();
           
            r.a = Convert.ToDouble(txta.Text);
            r.b = Convert.ToDouble(txtb.Text);
            r.c = Convert.ToDouble(txtc.Text);
            r.delta = r.b * r.b - 4 * r.a * r.c;
            lblx1.Text = r.firstRoot().ToString();
            lblx2.Text = r.secondroot().ToString();
        }
    }
}
