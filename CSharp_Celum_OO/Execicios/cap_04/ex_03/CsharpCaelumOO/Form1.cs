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
            double saldo = 500.00;
            

            if ( saldo < 0.0 ) 
            {
               
                MessageBox.Show("Você está negativo!");
            }
            else if ( saldo < 1000000.0 )
            {
                MessageBox.Show("Você é um bom cliente!");
            }
            else 
            {
                MessageBox.Show("Você é Milhonario");
            }


            
        }
    }
}
