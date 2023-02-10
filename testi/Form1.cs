using System;
using System.Windows.Forms;

namespace testi
{
    public partial class Form1 : Form
    {
        private readonly string[] firstNames = { "John", "Jane", "James", "Emily", "Michael", "Sarah" };
        private readonly string[] lastNames = { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis" };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int firstNameIndex = rnd.Next(firstNames.Length);
            int lastNameIndex = rnd.Next(lastNames.Length);

            string fullName = firstNames[firstNameIndex] + " " + lastNames[lastNameIndex];

            MessageBox.Show("Generated Name: " + fullName);
        }
    }
}