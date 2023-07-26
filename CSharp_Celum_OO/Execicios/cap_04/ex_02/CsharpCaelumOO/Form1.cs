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
            double saldo = 5.00;
            double valorSaque = 10.0;

            if ( saldo >= valorSaque ) 
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque Realizado com sucesso, valor saldo" + saldo);
            }
            else 
            {
                MessageBox.Show("Saldo Insuficiente");
            }


            
        }
    }
}
