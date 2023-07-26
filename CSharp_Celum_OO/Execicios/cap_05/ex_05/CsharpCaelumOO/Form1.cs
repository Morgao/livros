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
            int soma = 0;
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    MessageBox.Show("Divisivel por 3: " + i);
                }
                else if (i % 4 == 0)
                {
                    MessageBox.Show("Divisivel por 4: " + i);
                }
            }
            



        }
    }
}
