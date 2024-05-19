using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capitulo02_cs_deitel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x, y;

            x = 2;
            y = 3;
           
            
            

            MessageBox.Show("x = ", + x);
            MessageBox.Show("O valor de x + x é " + (x + x));
            MessageBox.Show("x =");
            MessageBox.Show((x + y) + " = " + (y + x));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}



/// a primeira da erro pq não declaro variavel na string
// mesmo erro da primeira
// terceira roda so a string
// faz soma e mostra a soma é igual pq é associativa
