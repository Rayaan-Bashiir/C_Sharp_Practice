namespace AirlineTricket
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nameTextBox = new TextBox();
            ageTextBox = new TextBox();
            ticketsTextBox = new TextBox();
            baggageTextBox = new TextBox();
            classGroupBox = new GroupBox();
            businessRadioButton = new RadioButton();
            normalRadioButton = new RadioButton();
            firstRadioButton = new RadioButton();
            insuranceCheckBox = new CheckBox();
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            detailsListBox = new ListBox();
            classGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(16, 29);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 0;
            label1.Text = "Passenger Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(16, 83);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 1;
            label2.Text = "Passenger Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(13, 137);
            label3.Name = "label3";
            label3.Size = new Size(180, 25);
            label3.TabIndex = 2;
            label3.Text = "Number of Trickets:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(16, 197);
            label4.Name = "label4";
            label4.Size = new Size(196, 25);
            label4.TabIndex = 3;
            label4.Text = "Baggage Weight(Kg):";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            nameTextBox.Location = new Point(254, 26);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(502, 31);
            nameTextBox.TabIndex = 4;
            // 
            // ageTextBox
            // 
            ageTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ageTextBox.Location = new Point(254, 77);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(502, 31);
            ageTextBox.TabIndex = 5;
            // 
            // ticketsTextBox
            // 
            ticketsTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ticketsTextBox.Location = new Point(254, 134);
            ticketsTextBox.Name = "ticketsTextBox";
            ticketsTextBox.Size = new Size(502, 31);
            ticketsTextBox.TabIndex = 6;
            // 
            // baggageTextBox
            // 
            baggageTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            baggageTextBox.Location = new Point(254, 191);
            baggageTextBox.Name = "baggageTextBox";
            baggageTextBox.Size = new Size(502, 31);
            baggageTextBox.TabIndex = 7;
            // 
            // classGroupBox
            // 
            classGroupBox.Controls.Add(businessRadioButton);
            classGroupBox.Controls.Add(normalRadioButton);
            classGroupBox.Controls.Add(firstRadioButton);
            classGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            classGroupBox.Location = new Point(16, 251);
            classGroupBox.Name = "classGroupBox";
            classGroupBox.Size = new Size(372, 134);
            classGroupBox.TabIndex = 8;
            classGroupBox.TabStop = false;
            classGroupBox.Text = "Travel Class";
            // 
            // businessRadioButton
            // 
            businessRadioButton.AutoSize = true;
            businessRadioButton.Location = new Point(72, 90);
            businessRadioButton.Name = "businessRadioButton";
            businessRadioButton.Size = new Size(173, 29);
            businessRadioButton.TabIndex = 2;
            businessRadioButton.TabStop = true;
            businessRadioButton.Text = "Business Class";
            businessRadioButton.TextAlign = ContentAlignment.MiddleCenter;
            businessRadioButton.UseVisualStyleBackColor = true;
            // 
            // normalRadioButton
            // 
            normalRadioButton.AutoSize = true;
            normalRadioButton.Location = new Point(164, 45);
            normalRadioButton.Name = "normalRadioButton";
            normalRadioButton.Size = new Size(162, 29);
            normalRadioButton.TabIndex = 1;
            normalRadioButton.TabStop = true;
            normalRadioButton.Text = "Normal Class";
            normalRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstRadioButton
            // 
            firstRadioButton.AutoSize = true;
            firstRadioButton.Location = new Point(7, 45);
            firstRadioButton.Name = "firstRadioButton";
            firstRadioButton.Size = new Size(132, 29);
            firstRadioButton.TabIndex = 0;
            firstRadioButton.TabStop = true;
            firstRadioButton.Text = "First Class";
            firstRadioButton.UseVisualStyleBackColor = true;
            firstRadioButton.CheckedChanged += firstRadioButton_CheckedChanged;
            // 
            // insuranceCheckBox
            // 
            insuranceCheckBox.AutoSize = true;
            insuranceCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            insuranceCheckBox.Location = new Point(13, 410);
            insuranceCheckBox.Name = "insuranceCheckBox";
            insuranceCheckBox.Size = new Size(352, 29);
            insuranceCheckBox.TabIndex = 9;
            insuranceCheckBox.Text = "Add Travel insurance ($25 per ticket)";
            insuranceCheckBox.UseVisualStyleBackColor = true;
            insuranceCheckBox.CheckedChanged += insuranceCheckBox_CheckedChanged;
            // 
            // calculateButton
            // 
            calculateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            calculateButton.Location = new Point(88, 492);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(123, 34);
            calculateButton.TabIndex = 10;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            clearButton.Location = new Point(333, 492);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(123, 34);
            clearButton.TabIndex = 11;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            exitButton.Location = new Point(563, 492);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(123, 34);
            exitButton.TabIndex = 12;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // detailsListBox
            // 
            detailsListBox.FormattingEnabled = true;
            detailsListBox.ItemHeight = 25;
            detailsListBox.Location = new Point(480, 235);
            detailsListBox.Name = "detailsListBox";
            detailsListBox.Size = new Size(425, 229);
            detailsListBox.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 561);
            Controls.Add(detailsListBox);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(insuranceCheckBox);
            Controls.Add(classGroupBox);
            Controls.Add(baggageTextBox);
            Controls.Add(ticketsTextBox);
            Controls.Add(ageTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Airline Tricket Booking System";
            classGroupBox.ResumeLayout(false);
            classGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nameTextBox;
        private TextBox ageTextBox;
        private TextBox ticketsTextBox;
        private TextBox baggageTextBox;
        private GroupBox classGroupBox;
        private RadioButton businessRadioButton;
        private RadioButton normalRadioButton;
        private RadioButton firstRadioButton;
        private CheckBox insuranceCheckBox;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
        private ListBox detailsListBox;
    }
}
