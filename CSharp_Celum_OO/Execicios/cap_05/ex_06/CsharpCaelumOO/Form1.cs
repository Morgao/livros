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
            int fatorial = 1;
            MessageBox.Show("fatorial de 0! e iugal: " + fatorial);
            for (int i = 1; i <= 10; i++)
            {
                fatorial = fatorial * i;
                MessageBox.Show("Fatorial de" + i + "! e igual: " + fatorial);
            }
            



        }
    }
}
