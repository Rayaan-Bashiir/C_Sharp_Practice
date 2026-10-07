using System.Windows.Markup;

namespace Payroll_With_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string[] values = { hoursWorkedTextBox.Text, hourlyPayRateTextBox.Text };

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i].Length == 0)
                {
                    MessageBox.Show("Please fill in both fields.");
                    return;
                }

                for (int j = 0; j < values[i].Length; j++)
                {
                    if (!char.IsDigit(values[i][j]) && values[i][j] != '.')
                    {
                        MessageBox.Show("Please enter numbers only.");
                        return;
                    }
                }
            }

            double hours = double.Parse(hoursWorkedTextBox.Text);
            double rate = double.Parse(hourlyPayRateTextBox.Text);

            double grossPay;

            if (hours <= 40)
            {
                grossPay = hours * rate;
            }
            else
            {
                double overtimeHours = hours - 40;
                grossPay = (40 * rate) + (overtimeHours * rate * 1.5);
            }

            grossPayLabel.Text = grossPay.ToString("0.00");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clearing the box
            hourlyPayRateTextBox.Clear();
            hourlyPayRateTextBox.Clear();
            //clearing the lebel
            grossPayLabel.Text = "";
        }
    }
}
