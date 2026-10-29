namespace Assignment_Files
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
            createButton = new Button();
            readButton = new Button();
            deleteButton = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // createButton
            // 
            createButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            createButton.Location = new Point(12, 30);
            createButton.Name = "createButton";
            createButton.Size = new Size(209, 77);
            createButton.TabIndex = 0;
            createButton.Text = "Creating New FIle";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // readButton
            // 
            readButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            readButton.Location = new Point(247, 30);
            readButton.Name = "readButton";
            readButton.Size = new Size(209, 77);
            readButton.TabIndex = 1;
            readButton.Text = "Other Reading";
            readButton.UseVisualStyleBackColor = true;
            readButton.Click += readButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deleteButton.Location = new Point(131, 160);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(209, 77);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(511, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(277, 329);
            listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(deleteButton);
            Controls.Add(readButton);
            Controls.Add(createButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button createButton;
        private Button readButton;
        private Button deleteButton;
        private ListBox listBox1;
    }
}
