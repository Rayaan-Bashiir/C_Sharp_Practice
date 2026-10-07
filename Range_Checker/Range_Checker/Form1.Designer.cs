namespace Range_Checker
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
            txtNumber = new TextBox();
            lblDecision = new Label();
            btnCheck = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 36);
            label1.Name = "label1";
            label1.Size = new Size(487, 30);
            label1.TabIndex = 0;
            label1.Text = "Enter an inteher in the range of 1 throught 10";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(286, 160);
            label2.Name = "label2";
            label2.Size = new Size(171, 30);
            label2.TabIndex = 1;
            label2.Text = "Range Decision";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(222, 99);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(294, 31);
            txtNumber.TabIndex = 2;
            // 
            // lblDecision
            // 
            lblDecision.BorderStyle = BorderStyle.FixedSingle;
            lblDecision.Location = new Point(167, 218);
            lblDecision.Name = "lblDecision";
            lblDecision.Size = new Size(398, 55);
            lblDecision.TabIndex = 3;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCheck.Location = new Point(133, 314);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(223, 97);
            btnCheck.TabIndex = 4;
            btnCheck.Text = "Check Qualification";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClear.Location = new Point(377, 292);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(128, 70);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnExit.Location = new Point(377, 368);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(128, 70);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCheck);
            Controls.Add(lblDecision);
            Controls.Add(txtNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Range Checked";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNumber;
        private Label lblDecision;
        private Button btnCheck;
        private Button btnClear;
        private Button btnExit;
    }
}
