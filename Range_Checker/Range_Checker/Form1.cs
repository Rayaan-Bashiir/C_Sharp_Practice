namespace Range_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int number;
            if (!int.TryParse(txtNumber.Text, out number))
            {
                lblDecision.Text = "please enter an integer.";
            }
            else if (number >= 1 && number <= 10)
            {
                lblDecision.Text = "Thie number is in the range.";
            }
            else if (number < 1 || number > 10)
            {
                lblDecision.Text = "The number is out of range.";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Clear();
            lblDecision.Text = "";
            txtNumber.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
