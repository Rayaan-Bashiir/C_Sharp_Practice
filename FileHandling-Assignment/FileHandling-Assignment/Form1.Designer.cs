namespace FileHandling_Assignment
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
            btnopen = new Button();
            button1 = new Button();
            btnclear = new Button();
            listReading = new ListBox();
            textinput = new TextBox();
            openFile = new OpenFileDialog();
            saveFile = new SaveFileDialog();
            SuspendLayout();
            // 
            // btnopen
            // 
            btnopen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnopen.Location = new Point(12, 32);
            btnopen.Name = "btnopen";
            btnopen.Size = new Size(147, 54);
            btnopen.TabIndex = 0;
            btnopen.Text = "Open File Dialog";
            btnopen.UseVisualStyleBackColor = true;
            btnopen.Click += btnopen_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(12, 132);
            button1.Name = "button1";
            button1.Size = new Size(147, 54);
            button1.TabIndex = 1;
            button1.Text = "Save File Dialog";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnclear.Location = new Point(12, 236);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(147, 54);
            btnclear.TabIndex = 2;
            btnclear.Text = "Clear Listbox";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += button3_Click;
            // 
            // listReading
            // 
            listReading.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            listReading.FormattingEnabled = true;
            listReading.Location = new Point(434, 12);
            listReading.Name = "listReading";
            listReading.Size = new Size(354, 404);
            listReading.TabIndex = 3;
            // 
            // textinput
            // 
            textinput.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textinput.Location = new Point(78, 389);
            textinput.Name = "textinput";
            textinput.Size = new Size(81, 27);
            textinput.TabIndex = 4;
            // 
            // openFile
            // 
            openFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textinput);
            Controls.Add(listReading);
            Controls.Add(btnclear);
            Controls.Add(button1);
            Controls.Add(btnopen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnopen;
        private Button button1;
        private Button btnclear;
        private ListBox listReading;
        private TextBox textinput;
        private OpenFileDialog openFile;
        private SaveFileDialog saveFile;
    }
}
