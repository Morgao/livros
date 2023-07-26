using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
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
            int fib1, fib2, fibonacci;
            fib1 = 0;
            fib2 = 1;
            fibonacci = 0;
            

            MessageBox.Show(", "+fib1);
            while (fibonacci < 100)
            {
                fibonacci = fib1 + fib2;
                MessageBox.Show(", "+fibonacci);
                fib1 = fib2;
                fib2 = fibonacci;


            }


        }
    }
}
