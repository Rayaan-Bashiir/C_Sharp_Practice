namespace Test_Score_Average
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
            txtScore1 = new TextBox();
            txtScore2 = new TextBox();
            txtScore3 = new TextBox();
            label4 = new Label();
            lblAverage = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(11, 32);
            label1.Name = "label1";
            label1.Size = new Size(152, 30);
            label1.TabIndex = 0;
            label1.Text = "Teat Score #1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(11, 78);
            label2.Name = "label2";
            label2.Size = new Size(152, 30);
            label2.TabIndex = 1;
            label2.Text = "Teat Score #2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(11, 123);
            label3.Name = "label3";
            label3.Size = new Size(152, 30);
            label3.TabIndex = 2;
            label3.Text = "Teat Score #3";
            // 
            // txtScore1
            // 
            txtScore1.Location = new Point(178, 31);
            txtScore1.Name = "txtScore1";
            txtScore1.Size = new Size(421, 31);
            txtScore1.TabIndex = 3;
            // 
            // txtScore2
            // 
            txtScore2.Location = new Point(178, 78);
            txtScore2.Name = "txtScore2";
            txtScore2.Size = new Size(421, 31);
            txtScore2.TabIndex = 4;
            // 
            // txtScore3
            // 
            txtScore3.Location = new Point(178, 124);
            txtScore3.Name = "txtScore3";
            txtScore3.Size = new Size(421, 31);
            txtScore3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(143, 227);
            label4.Name = "label4";
            label4.Size = new Size(99, 30);
            label4.TabIndex = 6;
            label4.Text = "Average";
            // 
            // lblAverage
            // 
            lblAverage.BorderStyle = BorderStyle.FixedSingle;
            lblAverage.Location = new Point(258, 199);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(271, 71);
            lblAverage.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCalculate.Location = new Point(143, 323);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(162, 99);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate Average";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClear.Location = new Point(321, 325);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(142, 41);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnExit.Location = new Point(321, 372);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(142, 41);
            btnExit.TabIndex = 10;
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
            Controls.Add(btnCalculate);
            Controls.Add(lblAverage);
            Controls.Add(label4);
            Controls.Add(txtScore3);
            Controls.Add(txtScore2);
            Controls.Add(txtScore1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtScore1;
        private TextBox txtScore2;
        private TextBox txtScore3;
        private Label label4;
        private Label lblAverage;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}
