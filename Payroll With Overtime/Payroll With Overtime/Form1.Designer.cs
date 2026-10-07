namespace Payroll_With_Overtime
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
            grossPayLabel = new Label();
            hoursWorkedTextBox = new TextBox();
            hourlyPayRateTextBox = new TextBox();
            clearButton = new Button();
            calculateButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(25, 34);
            label1.Name = "label1";
            label1.Size = new Size(168, 30);
            label1.TabIndex = 0;
            label1.Text = "Hours Worked:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(25, 79);
            label2.Name = "label2";
            label2.Size = new Size(181, 30);
            label2.TabIndex = 1;
            label2.Text = "Hourly pay rate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(25, 123);
            label3.Name = "label3";
            label3.Size = new Size(121, 30);
            label3.TabIndex = 2;
            label3.Text = "Gross pay:";
            // 
            // grossPayLabel
            // 
            grossPayLabel.BorderStyle = BorderStyle.FixedSingle;
            grossPayLabel.Location = new Point(258, 156);
            grossPayLabel.Name = "grossPayLabel";
            grossPayLabel.Size = new Size(283, 67);
            grossPayLabel.TabIndex = 3;
            // 
            // hoursWorkedTextBox
            // 
            hoursWorkedTextBox.Location = new Point(258, 26);
            hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            hoursWorkedTextBox.Size = new Size(374, 31);
            hoursWorkedTextBox.TabIndex = 4;
            // 
            // hourlyPayRateTextBox
            // 
            hourlyPayRateTextBox.Location = new Point(258, 92);
            hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            hourlyPayRateTextBox.Size = new Size(374, 31);
            hourlyPayRateTextBox.TabIndex = 5;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            clearButton.Location = new Point(248, 315);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(189, 71);
            clearButton.TabIndex = 6;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // calculateButton
            // 
            calculateButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            calculateButton.Location = new Point(53, 315);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(189, 71);
            calculateButton.TabIndex = 7;
            calculateButton.Text = "Calculate Gross Pay";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            exitButton.Location = new Point(443, 315);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(189, 71);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(calculateButton);
            Controls.Add(clearButton);
            Controls.Add(hourlyPayRateTextBox);
            Controls.Add(hoursWorkedTextBox);
            Controls.Add(grossPayLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label grossPayLabel;
        private TextBox hoursWorkedTextBox;
        private TextBox hourlyPayRateTextBox;
        private Button clearButton;
        private Button calculateButton;
        private Button exitButton;
    }
}
