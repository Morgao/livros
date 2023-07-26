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
            int numero = 5;
           

            for(int i = 1; i< 5; i++) 
            {
                
                for (int j = 1; j<=i; j++) 
                {
                    //valor = i * j +
                    MessageBox.Show(" "+i * j);
                    
                    


                }
                MessageBox.Show(" ");

            }

        }
    }
}
