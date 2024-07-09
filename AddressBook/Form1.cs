using System;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;
            string entry = $"Name: {name}, Email: {email}, Phone: {phone}";
            listBoxEntries.Items.Add(entry);
            textBoxName.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();
        }
    }
}
