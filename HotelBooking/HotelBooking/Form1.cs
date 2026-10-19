namespace HotelBooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            ageTextBox.Clear();
            nightsTextBox.Clear();
            guestsTextBox.Clear();

            standardRadioButton.Checked = false;
            normalRadioButton.Checked = false;
            highRadioButton.Checked = false;

            breakfastCheckBox.Checked = false;
            detailsListBox.Items.Clear();

            nameTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int age, nights, guests;
            bool approved = true;
            string message = "";

            
            if (nameTextBox.Text == "")
            {
                approved = false;
                message = "Guest name cannot be empty";
            }
            else if (!int.TryParse(ageTextBox.Text, out age) || age < 18 || age > 90)
            {
                approved = false;
                message = "Guest age must be between 18 and 90";
            }
            else if (!int.TryParse(nightsTextBox.Text, out nights) || nights < 1 || nights > 30)
            {
                approved = false;
                message = "Number of nights must be between 1 and 30";
            }
            else if (!int.TryParse(guestsTextBox.Text, out guests) || guests < 1 || guests > 6)
            {
                approved = false;
                message = "Number of guests must be between 1 and 6";
            }
            else if (!standardRadioButton.Checked && !normalRadioButton.Checked && !highRadioButton.Checked)
            {
                approved = false;
                message = "Please select room type";
            }

            if (approved == false)
            {
                detailsListBox.Items.Clear();
                detailsListBox.Items.Add("Booking REJECTED");
                detailsListBox.Items.Add(message);
                return;
            }

            age = int.Parse(ageTextBox.Text);
            nights = int.Parse(nightsTextBox.Text);
            guests = int.Parse(guestsTextBox.Text);


            int roomType = 0;
            if (standardRadioButton.Checked) roomType = 1;
            else if (normalRadioButton.Checked) roomType = 2;
            else roomType = 3;

            double rate = 0;
            int maxGuests = 0;
            string roomName = "";

            switch (roomType)
            {
                case 1:
                    rate = 50;
                    maxGuests = 2;
                    roomName = "Standard";
                    break;
                case 2:
                    rate = 80;
                    maxGuests = 4;
                    roomName = "Normal";
                    break;
                case 3:
                    rate = 130;
                    maxGuests = 6;
                    roomName = "Hight";
                    break;
            }

            
            if (guests > maxGuests)
            {
                approved = false;
                message = roomName + " room allows a maximum of " + maxGuests + " guests";
            }

            if (approved == false)
            {
                detailsListBox.Items.Clear();
                detailsListBox.Items.Add("Booking REJECTED");
                detailsListBox.Items.Add(message);
                return;
            }

            
            double baseCost = rate * nights;

           
            double discountPercent = 0;
            if (nights >= 10)
            {
                discountPercent = 12;
            }
            else if (nights >= 5)
            {
                discountPercent = 5;
            }

         
            if (age >= 60)
            {
                discountPercent += 5;
            }

            double discountAmount = baseCost * discountPercent / 100;
            double total = baseCost - discountAmount;

            
            double breakfastCost = 0;
            if (breakfastCheckBox.Checked)
            {
                breakfastCost = 10 * guests * nights;
                total += breakfastCost;
            }

            
            double surcharge = 0;
            if (guests > 4)
            {
                surcharge = total * 5 / 100;
                total += surcharge;
            }

            
            detailsListBox.Items.Clear();
            detailsListBox.Items.Add("Booking APPROVED");
            detailsListBox.Items.Add("Guest: " + nameTextBox.Text);
            detailsListBox.Items.Add("Room: " + roomName);
            detailsListBox.Items.Add("Nights: " + nights);
            detailsListBox.Items.Add("Guests: " + guests);
            detailsListBox.Items.Add("Base cost: " + baseCost.ToString("c"));
            detailsListBox.Items.Add("Discount: " + discountAmount.ToString("c"));
            detailsListBox.Items.Add("Breakfast: " + breakfastCost.ToString("c"));
            detailsListBox.Items.Add("Service surcharge: " + surcharge.ToString("c"));
            detailsListBox.Items.Add("TOTAL: " + total.ToString("c"));
        }
    }
    }


