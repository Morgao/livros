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
            int idadeMaria = 25;
            int idadeMatheus = 52;
            int idadejoao = 35;
            int media;
            media = (idadejoao + idadeMaria + idadeMatheus)/3;
            MessageBox.Show("A media das idades pe: "+ media);
        }
    }
}
