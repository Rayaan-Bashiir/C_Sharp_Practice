namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double score1, score2, score3;

            if (!double.TryParse(txtScore1.Text, out score1))
            {
                MessageBox.Show("Please enter a valid number for Score 1.");
            }
            else if (!double.TryParse(txtScore2.Text, out score2))
            {
                MessageBox.Show("Please enter a valid number for Score 2.");
            }
            else if (!double.TryParse(txtScore3.Text, out score3))
            {
                MessageBox.Show("Please enter a valid number for Score 3.");
            }
            else if (score1 < 0 || score1 > 100)
            {
                MessageBox.Show("Score 1 must be between 0 and 100.");
            }
            else if (score2 < 0 || score2 > 100)
            {
                MessageBox.Show("Score 2 must be between 0 and 100.");
            }
            else if (score3 < 0 || score3 > 100)
            {
                MessageBox.Show("Score 3 must be between 0 and 100.");
            }
            else
            {
                double average = (score1 + score2 + score3) / 3;
                lblAverage.Text = average.ToString("F1");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScore1.Clear();
            txtScore2.Clear();
            txtScore3.Clear();
            lblAverage.Text = "";
            txtScore1.Focus();
        }
    }
}
