using System.IO;

namespace Assignment_Files
{
    public partial class Form1 : Form
    {
        private string path = "Index.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile = File.CreateText(path);
            outputFile.WriteLine("Welcome Jamhuuriya");
            outputFile.WriteLine("Welcome CA242 & CA244");
            outputFile.WriteLine("Files are easy");
            outputFile.Close();

            MessageBox.Show("File created");
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (!File.Exists(path))
            {
                MessageBox.Show("File does not exist");
                return;
            }

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                listBox1.Items.Add(line);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                listBox1.Items.Clear();
                MessageBox.Show("File deleted");
            }
            else
            {
                MessageBox.Show("File does not exist");
            }
        }
    }
}
