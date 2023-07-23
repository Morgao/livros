namespace Codigo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x, total, b;
            total = 0;
            x = 1;

            while (x <= 10)
            {
                total = total + x;
                x++;

            }
            txbResultado.Text = (total.ToString());


        }


        
    }
}