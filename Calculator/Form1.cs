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
            if (txtA.Text!=String.Empty && txtB.Text!=String.Empty)
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                txtResult.Text = (a + b).ToString(); 
            }
        }
    }
}