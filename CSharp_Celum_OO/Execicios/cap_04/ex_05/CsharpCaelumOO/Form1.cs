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
            double valorDaNotaFiscal = 78800.00;
            double imposto;

            

            if ( valorDaNotaFiscal <= 999 )
            {
                imposto = 0.02;
                valorDaNotaFiscal = valorDaNotaFiscal - (valorDaNotaFiscal * imposto)  ;
                MessageBox.Show("Despois dos descontos: " + valorDaNotaFiscal);
            }
            else if ((valorDaNotaFiscal>=1000)&&(valorDaNotaFiscal<=2999))
            {
                imposto = 0.025;
                valorDaNotaFiscal = valorDaNotaFiscal - (valorDaNotaFiscal * imposto);
                MessageBox.Show("Despois dos descontos: " + valorDaNotaFiscal);
            }
            else if ((valorDaNotaFiscal >= 3000) && (valorDaNotaFiscal <= 6999))
            {
                imposto = 0.028;
                valorDaNotaFiscal = valorDaNotaFiscal - (valorDaNotaFiscal * imposto);
                MessageBox.Show("Despois dos descontos: " + valorDaNotaFiscal);
            }
            else if (valorDaNotaFiscal> 7000)
            {
                imposto = 0.03;
                valorDaNotaFiscal = valorDaNotaFiscal - (valorDaNotaFiscal * imposto);
                MessageBox.Show("Despois dos descontos: " + valorDaNotaFiscal);

            }




        }
    }
}
