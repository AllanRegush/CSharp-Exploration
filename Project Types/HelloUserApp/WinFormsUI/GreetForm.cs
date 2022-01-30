using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class GreetForm : Form
    {
        public GreetForm()
        {
            InitializeComponent();
        }

        private void GreetButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                MessageBox.Show("Please Enter a First Name");
                firstNameTextBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                MessageBox.Show("Please Enter a Last Name");
                lastNameLabel.Focus();
                return;
            }

            MessageBox.Show($"Hello, {firstNameTextBox.Text} {lastNameTextBox.Text}");
        }
    }
}
