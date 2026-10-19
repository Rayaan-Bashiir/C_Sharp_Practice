namespace HotelBooking
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
            nightsTextBox = new TextBox();
            guestsTextBox = new TextBox();
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            roomGroupBox = new GroupBox();
            highRadioButton = new RadioButton();
            normalRadioButton = new RadioButton();
            standardRadioButton = new RadioButton();
            breakfastCheckBox = new CheckBox();
            detailsListBox = new ListBox();
            roomGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 0;
            label1.Text = "Guest Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(24, 77);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 1;
            label2.Text = "Guest Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(24, 119);
            label3.Name = "label3";
            label3.Size = new Size(170, 25);
            label3.TabIndex = 2;
            label3.Text = "Number of Nights:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(24, 166);
            label4.Name = "label4";
            label4.Size = new Size(163, 25);
            label4.TabIndex = 3;
            label4.Text = "Number of Guest:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(270, 26);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(453, 31);
            nameTextBox.TabIndex = 4;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(270, 77);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(453, 31);
            ageTextBox.TabIndex = 5;
            // 
            // nightsTextBox
            // 
            nightsTextBox.Location = new Point(270, 129);
            nightsTextBox.Name = "nightsTextBox";
            nightsTextBox.Size = new Size(453, 31);
            nightsTextBox.TabIndex = 6;
            // 
            // guestsTextBox
            // 
            guestsTextBox.Location = new Point(270, 181);
            guestsTextBox.Name = "guestsTextBox";
            guestsTextBox.Size = new Size(453, 31);
            guestsTextBox.TabIndex = 7;
            // 
            // calculateButton
            // 
            calculateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            calculateButton.Location = new Point(72, 544);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(112, 34);
            calculateButton.TabIndex = 8;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            clearButton.Location = new Point(214, 544);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 34);
            clearButton.TabIndex = 9;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            exitButton.Location = new Point(351, 544);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 10;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // roomGroupBox
            // 
            roomGroupBox.Controls.Add(highRadioButton);
            roomGroupBox.Controls.Add(normalRadioButton);
            roomGroupBox.Controls.Add(standardRadioButton);
            roomGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomGroupBox.Location = new Point(24, 259);
            roomGroupBox.Name = "roomGroupBox";
            roomGroupBox.Size = new Size(439, 150);
            roomGroupBox.TabIndex = 11;
            roomGroupBox.TabStop = false;
            roomGroupBox.Text = "Room Type";
            // 
            // highRadioButton
            // 
            highRadioButton.AutoSize = true;
            highRadioButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            highRadioButton.Location = new Point(327, 46);
            highRadioButton.Name = "highRadioButton";
            highRadioButton.Size = new Size(85, 29);
            highRadioButton.TabIndex = 2;
            highRadioButton.TabStop = true;
            highRadioButton.Text = "Hight";
            highRadioButton.UseVisualStyleBackColor = true;
            // 
            // normalRadioButton
            // 
            normalRadioButton.AutoSize = true;
            normalRadioButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            normalRadioButton.Location = new Point(166, 46);
            normalRadioButton.Name = "normalRadioButton";
            normalRadioButton.Size = new Size(100, 29);
            normalRadioButton.TabIndex = 1;
            normalRadioButton.TabStop = true;
            normalRadioButton.Text = "Normal";
            normalRadioButton.UseVisualStyleBackColor = true;
            // 
            // standardRadioButton
            // 
            standardRadioButton.AutoSize = true;
            standardRadioButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            standardRadioButton.Location = new Point(10, 46);
            standardRadioButton.Name = "standardRadioButton";
            standardRadioButton.Size = new Size(114, 29);
            standardRadioButton.TabIndex = 0;
            standardRadioButton.TabStop = true;
            standardRadioButton.Text = "Standard";
            standardRadioButton.UseVisualStyleBackColor = true;
            // 
            // breakfastCheckBox
            // 
            breakfastCheckBox.AutoSize = true;
            breakfastCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            breakfastCheckBox.Location = new Point(24, 453);
            breakfastCheckBox.Name = "breakfastCheckBox";
            breakfastCheckBox.Size = new Size(328, 29);
            breakfastCheckBox.TabIndex = 12;
            breakfastCheckBox.Text = "Breakfast (10 per Guest per night)";
            breakfastCheckBox.UseVisualStyleBackColor = true;
            // 
            // detailsListBox
            // 
            detailsListBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            detailsListBox.FormattingEnabled = true;
            detailsListBox.ItemHeight = 25;
            detailsListBox.Location = new Point(524, 259);
            detailsListBox.Name = "detailsListBox";
            detailsListBox.Size = new Size(393, 304);
            detailsListBox.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 619);
            Controls.Add(detailsListBox);
            Controls.Add(breakfastCheckBox);
            Controls.Add(roomGroupBox);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(guestsTextBox);
            Controls.Add(nightsTextBox);
            Controls.Add(ageTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Hotel Room Booking System";
            roomGroupBox.ResumeLayout(false);
            roomGroupBox.PerformLayout();
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
        private TextBox nightsTextBox;
        private TextBox guestsTextBox;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
        private GroupBox roomGroupBox;
        private RadioButton highRadioButton;
        private RadioButton normalRadioButton;
        private RadioButton standardRadioButton;
        private CheckBox breakfastCheckBox;
        private ListBox detailsListBox;
    }
}
