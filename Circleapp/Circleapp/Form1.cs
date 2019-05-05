using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circleapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string r = textBox1.Text;
            double r1 = Convert.ToDouble(r);
            double c = r1 * 2 * 3.14;
            double s = r1 * r1 * 3.14;
            label1.Text = Convert.ToString(c);
            label2.Text = Convert.ToString(s);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);

        }
    }
}
