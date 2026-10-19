namespace CourseRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void levelGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            idTextBox.Clear();
            coursesTextBox.Clear();


            year1RadioButton.Checked = false;
            year2RadioButton.Checked = false;
            year3RadioButton.Checked = false;
            year4RadioButton.Checked = false;



            accommodationCheckBox.Checked = false;
            transportCheckBox.Checked = false;


            nameLabel.Text = "";
            levelLabel.Text = "";
            tuitionLabel.Text = "";
            accommodationLabel.Text = "";
            transportLabel.Text = "";
            discountLabel.Text = "";
            finalLabel.Text = "";

            nameTextBox.Focus();

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int courses;
            bool approved = true;
            string message = "";

            if (nameTextBox.Text == "")
            {
                approved = false;
                message = "Please enter student name";
            }
            else if (!int.TryParse(coursesTextBox.Text, out courses) || courses < 1 || courses > 8)
            {
                approved = false;
                message = "Number of courses must be between 1 and 8";
            }
            else if (!year1RadioButton.Checked && !year2RadioButton.Checked &&
                     !year3RadioButton.Checked && !year4RadioButton.Checked)
            {
                approved = false;
                message = "Please select study level";
            }

            if (approved == false)
            {
                MessageBox.Show(message);
                return;
            }

            courses = int.Parse(coursesTextBox.Text);

            double feePerCourse = 0;
            string level = "";

            if (year1RadioButton.Checked)
            {
                feePerCourse = 40;
                level = "Year 1";
            }
            else if (year2RadioButton.Checked)
            {
                feePerCourse = 45;
                level = "Year 2";
            }
            else if (year3RadioButton.Checked)
            {
                feePerCourse = 50;
                level = "Year 3";
            }
            else
            {
                feePerCourse = 55;
                level = "Year 4";
            }

            double tuition = feePerCourse * courses;

            double accommodationFee = 0;
            double transportFee = 0;

            if (accommodationCheckBox.Checked)
            {
                accommodationFee = 120;
            }
            if (transportCheckBox.Checked)
            {
                transportFee = 50;
            }

            double discountPercent = 0;

            if (courses >= 6)
            {
                discountPercent = 10;
            }

            if (accommodationCheckBox.Checked && transportCheckBox.Checked)
            {
                if (courses >= 5)
                {
                    discountPercent += 5;
                }
            }

            double discountAmount = tuition * discountPercent / 100;
            double finalAmount = tuition + accommodationFee + transportFee - discountAmount;

            nameLabel.Text = "Name: " + nameTextBox.Text;
            levelLabel.Text = "Study Level: " + level;
            tuitionLabel.Text = "Tuition Fee: " + tuition.ToString("c");
            accommodationLabel.Text = "Accommodation: " + accommodationFee.ToString("c");
            transportLabel.Text = "Transport: " + transportFee.ToString("c");
            discountLabel.Text = "Discount: " + discountAmount.ToString("c");
            finalLabel.Text = "Final Amount: " + finalAmount.ToString("c");
        }
    }
}