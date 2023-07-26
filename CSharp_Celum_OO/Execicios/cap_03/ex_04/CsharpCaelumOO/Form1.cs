using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpCaelumOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            double delta, a1, a2;
            a = 2;
            b = 4;
            c = 1;
            delta = (b * b) - 4 *( a * c);
            a1 = (double)(-b + Math.Sqrt(delta)) / (2 * a);
            a2 = (double)(-b - Math.Sqrt(delta)) / (2 * a);


            MessageBox.Show("valor de a1: " +a1+ " e o valor de a 2: "+ a2);
        }
    }
}
