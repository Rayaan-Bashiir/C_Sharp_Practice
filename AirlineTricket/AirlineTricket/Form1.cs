namespace AirlineTricket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void firstRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void insuranceCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            ageTextBox.Clear();
            ticketsTextBox.Clear();
            baggageTextBox.Clear();

            firstRadioButton.Checked = false;
            normalRadioButton.Checked = false;
            businessRadioButton.Checked = false;

            insuranceCheckBox.Checked = false;
            detailsListBox.Items.Clear();

            nameTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        { 
            int age, tickets;
            double baggage;
            bool bookingApproved = true;
            string message = "";

            
            if (nameTextBox.Text == "")
            {
                bookingApproved = false;
                message = "Passenger name cannot be empty";
            }
            else if (!int.TryParse(ageTextBox.Text, out age) || age < 1 || age > 100)
            {
                bookingApproved = false;
                message = "Passenger age must be between 1 and 100";
            }
            else if (!int.TryParse(ticketsTextBox.Text, out tickets) || tickets < 1 || tickets > 5)
            {
                bookingApproved = false;
                message = "Number of tickets must be between 1 and 5";
            }
            else if (!double.TryParse(baggageTextBox.Text, out baggage) || baggage < 0)
            {
                bookingApproved = false;
                message = "Baggage weight cannot be negative";
            }
            else if (!firstRadioButton.Checked && !normalRadioButton.Checked && !businessRadioButton.Checked)
            {
                bookingApproved = false;
                message = "Please select travel class";
            }

            if (bookingApproved == false)
            {
                detailsListBox.Items.Clear();
                detailsListBox.Items.Add("Booking REJECTED");
                detailsListBox.Items.Add(message);
                return;
            }

            age = int.Parse(ageTextBox.Text);
            tickets = int.Parse(ticketsTextBox.Text);
            baggage = double.Parse(baggageTextBox.Text);

            
            if (age < 12 && firstRadioButton.Checked)
            {
                bookingApproved = false;
                message = "Passengers below 12 cannot book First Class";
            }

            
            else if (baggage > 50)
            {
                bookingApproved = false;
                message = "Baggage cannot exceed 50 kg per passenger";
            }

            if (bookingApproved == false)
            {
                detailsListBox.Items.Clear();
                detailsListBox.Items.Add("Booking REJECTED");
                detailsListBox.Items.Add(message);
                return;
            }

            
            double ticketPrice = 0;
            string className = "";

            if (firstRadioButton.Checked)
            {
                ticketPrice = 500;
                className = "First Class";
            }
            else if (businessRadioButton.Checked)
            {
                ticketPrice = 300;
                className = "Business Class";
            }
            else
            {
                ticketPrice = 150;
                className = "Normal Class";
            }

            
            double baseCost = ticketPrice * tickets;

            
            double discountPercent = 0;
            if (tickets == 5)
            {
                discountPercent = 10;
            }
            else if (tickets >= 3)
            {
                discountPercent = 5;
            }

            
            if (age < 12)
            {
                discountPercent += 20;
            }
            else if (age >= 60)
            {
                discountPercent += 10;
            }

            double discountAmount = baseCost * discountPercent / 100;

            
            double insuranceCost = 0;
            if (insuranceCheckBox.Checked)
            {
                insuranceCost = 25 * tickets;
            }

            
            double extraBaggage = 0;
            double baggageFee = 0;
            if (baggage > 20)
            {
                extraBaggage = baggage - 20;
                baggageFee = extraBaggage * 5 * tickets;
            }

            double total = baseCost - discountAmount + insuranceCost + baggageFee;

            
            detailsListBox.Items.Clear();
            detailsListBox.Items.Add("Booking APPROVED");
            detailsListBox.Items.Add("Passenger: " + nameTextBox.Text);
            detailsListBox.Items.Add("Class: " + className);
            detailsListBox.Items.Add("Tickets: " + tickets);
            detailsListBox.Items.Add("Basic cost: " + baseCost.ToString("c"));
            detailsListBox.Items.Add("Discount (" + discountPercent + "%): " + discountAmount.ToString("c"));
            detailsListBox.Items.Add("Insurance: " + insuranceCost.ToString("c"));
            detailsListBox.Items.Add("Extra baggage fee: " + baggageFee.ToString("c"));
            detailsListBox.Items.Add("TOTAL: " + total.ToString("c"));
        }
    }
    }


