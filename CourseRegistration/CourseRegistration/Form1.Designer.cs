namespace CourseRegistration
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
            nameTextBox = new TextBox();
            idTextBox = new TextBox();
            coursesTextBox = new TextBox();
            levelGroupBox = new GroupBox();
            year4RadioButton = new RadioButton();
            year3RadioButton = new RadioButton();
            year2RadioButton = new RadioButton();
            year1RadioButton = new RadioButton();
            accommodationCheckBox = new CheckBox();
            transportCheckBox = new CheckBox();
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            nameLabel = new Label();
            tuitionLabel = new Label();
            levelLabel = new Label();
            accommodationLabel = new Label();
            transportLabel = new Label();
            discountLabel = new Label();
            finalLabel = new Label();
            levelGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(3, 43);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter Student Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(3, 91);
            label2.Name = "label2";
            label2.Size = new Size(158, 25);
            label2.TabIndex = 1;
            label2.Text = "Enter Student ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(3, 138);
            label3.Name = "label3";
            label3.Size = new Size(230, 25);
            label3.TabIndex = 2;
            label3.Text = "Enter Number of Courses:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(297, 31);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(434, 31);
            nameTextBox.TabIndex = 3;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(297, 90);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(434, 31);
            idTextBox.TabIndex = 4;
            // 
            // coursesTextBox
            // 
            coursesTextBox.Location = new Point(297, 153);
            coursesTextBox.Name = "coursesTextBox";
            coursesTextBox.Size = new Size(434, 31);
            coursesTextBox.TabIndex = 5;
            // 
            // levelGroupBox
            // 
            levelGroupBox.Controls.Add(year4RadioButton);
            levelGroupBox.Controls.Add(year3RadioButton);
            levelGroupBox.Controls.Add(year2RadioButton);
            levelGroupBox.Controls.Add(year1RadioButton);
            levelGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            levelGroupBox.Location = new Point(3, 208);
            levelGroupBox.Name = "levelGroupBox";
            levelGroupBox.Size = new Size(470, 130);
            levelGroupBox.TabIndex = 6;
            levelGroupBox.TabStop = false;
            levelGroupBox.Text = "Study Level";
            levelGroupBox.Enter += levelGroupBox_Enter;
            // 
            // year4RadioButton
            // 
            year4RadioButton.AutoSize = true;
            year4RadioButton.Location = new Point(239, 93);
            year4RadioButton.Name = "year4RadioButton";
            year4RadioButton.Size = new Size(88, 29);
            year4RadioButton.TabIndex = 3;
            year4RadioButton.TabStop = true;
            year4RadioButton.Text = "Year 4";
            year4RadioButton.UseVisualStyleBackColor = true;
            // 
            // year3RadioButton
            // 
            year3RadioButton.AutoSize = true;
            year3RadioButton.Location = new Point(239, 58);
            year3RadioButton.Name = "year3RadioButton";
            year3RadioButton.Size = new Size(88, 29);
            year3RadioButton.TabIndex = 2;
            year3RadioButton.TabStop = true;
            year3RadioButton.Text = "Year 3";
            year3RadioButton.UseVisualStyleBackColor = true;
            // 
            // year2RadioButton
            // 
            year2RadioButton.AutoSize = true;
            year2RadioButton.Location = new Point(7, 93);
            year2RadioButton.Name = "year2RadioButton";
            year2RadioButton.Size = new Size(88, 29);
            year2RadioButton.TabIndex = 1;
            year2RadioButton.TabStop = true;
            year2RadioButton.Text = "Year 2";
            year2RadioButton.UseVisualStyleBackColor = true;
            // 
            // year1RadioButton
            // 
            year1RadioButton.AutoSize = true;
            year1RadioButton.Location = new Point(7, 58);
            year1RadioButton.Name = "year1RadioButton";
            year1RadioButton.Size = new Size(88, 29);
            year1RadioButton.TabIndex = 0;
            year1RadioButton.TabStop = true;
            year1RadioButton.Text = "Year 1";
            year1RadioButton.UseVisualStyleBackColor = true;
            // 
            // accommodationCheckBox
            // 
            accommodationCheckBox.AutoSize = true;
            accommodationCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            accommodationCheckBox.Location = new Point(200, 354);
            accommodationCheckBox.Name = "accommodationCheckBox";
            accommodationCheckBox.Size = new Size(178, 29);
            accommodationCheckBox.TabIndex = 7;
            accommodationCheckBox.Text = "Accommodation";
            accommodationCheckBox.UseVisualStyleBackColor = true;
            // 
            // transportCheckBox
            // 
            transportCheckBox.AutoSize = true;
            transportCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            transportCheckBox.Location = new Point(12, 354);
            transportCheckBox.Name = "transportCheckBox";
            transportCheckBox.Size = new Size(121, 29);
            transportCheckBox.TabIndex = 8;
            transportCheckBox.Text = "Transport";
            transportCheckBox.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            calculateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            calculateButton.Location = new Point(49, 423);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(112, 34);
            calculateButton.TabIndex = 9;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            clearButton.Location = new Point(218, 423);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 34);
            clearButton.TabIndex = 10;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            exitButton.Location = new Point(390, 423);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 11;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.BorderStyle = BorderStyle.FixedSingle;
            nameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            nameLabel.Location = new Point(28, 510);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(205, 38);
            nameLabel.TabIndex = 12;
            // 
            // tuitionLabel
            // 
            tuitionLabel.BorderStyle = BorderStyle.FixedSingle;
            tuitionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tuitionLabel.Location = new Point(278, 510);
            tuitionLabel.Name = "tuitionLabel";
            tuitionLabel.Size = new Size(205, 38);
            tuitionLabel.TabIndex = 13;
            // 
            // levelLabel
            // 
            levelLabel.BorderStyle = BorderStyle.FixedSingle;
            levelLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            levelLabel.Location = new Point(526, 510);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new Size(205, 38);
            levelLabel.TabIndex = 14;
            // 
            // accommodationLabel
            // 
            accommodationLabel.BorderStyle = BorderStyle.FixedSingle;
            accommodationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            accommodationLabel.Location = new Point(757, 546);
            accommodationLabel.Name = "accommodationLabel";
            accommodationLabel.Size = new Size(205, 38);
            accommodationLabel.TabIndex = 15;
            // 
            // transportLabel
            // 
            transportLabel.BorderStyle = BorderStyle.FixedSingle;
            transportLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            transportLabel.Location = new Point(28, 585);
            transportLabel.Name = "transportLabel";
            transportLabel.Size = new Size(205, 38);
            transportLabel.TabIndex = 16;
            // 
            // discountLabel
            // 
            discountLabel.BorderStyle = BorderStyle.FixedSingle;
            discountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            discountLabel.Location = new Point(278, 585);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(205, 38);
            discountLabel.TabIndex = 17;
            // 
            // finalLabel
            // 
            finalLabel.BorderStyle = BorderStyle.FixedSingle;
            finalLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            finalLabel.Location = new Point(526, 585);
            finalLabel.Name = "finalLabel";
            finalLabel.Size = new Size(205, 38);
            finalLabel.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 648);
            Controls.Add(finalLabel);
            Controls.Add(discountLabel);
            Controls.Add(transportLabel);
            Controls.Add(accommodationLabel);
            Controls.Add(levelLabel);
            Controls.Add(tuitionLabel);
            Controls.Add(nameLabel);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(transportCheckBox);
            Controls.Add(accommodationCheckBox);
            Controls.Add(levelGroupBox);
            Controls.Add(coursesTextBox);
            Controls.Add(idTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "University Registration";
            levelGroupBox.ResumeLayout(false);
            levelGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nameTextBox;
        private TextBox idTextBox;
        private TextBox coursesTextBox;
        private GroupBox levelGroupBox;
        private RadioButton year1RadioButton;
        private RadioButton year4RadioButton;
        private RadioButton year3RadioButton;
        private RadioButton year2RadioButton;
        private CheckBox accommodationCheckBox;
        private CheckBox transportCheckBox;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
        private Label nameLabel;
        private Label tuitionLabel;
        private Label levelLabel;
        private Label accommodationLabel;
        private Label transportLabel;
        private Label discountLabel;
        private Label finalLabel;
    }
}
