namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (txtA.Text!=String.Empty)
=======
            if (txtA.Text!=String.Empty && txtB.Text!=String.Empty)
>>>>>>> feature-cal
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                txtResult.Text = (a + b).ToString(); 
            }
<<<<<<< HEAD
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            txtResult.Text = (a - b).ToString();
=======
>>>>>>> feature-cal
        }
    }
}