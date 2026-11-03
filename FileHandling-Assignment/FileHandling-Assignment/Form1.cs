using System.Windows.Forms;

namespace FileHandling_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = saveFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                StreamWriter writes;

                writes = File.AppendText(saveFile.FileName);

                writes.WriteLine(textinput.Text);

                writes.Close();

                MessageBox.Show("File saved successfully");
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Not saved the file");
            }
        }


        private void btnopen_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = openFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                StreamReader read;
                read = File.OpenText(openFile.FileName);

                string line;

                while (read.EndOfStream == false)
                {
                    line = read.ReadLine();
                    listReading.Items.Add(line);
                }

                read.Close();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Not open file");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listReading.Items.Clear();
        }
    }
    }


