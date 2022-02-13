using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMiniProjectLibrary;
using WinFormsMiniProjectLibrary.Models;

namespace WinFormMiniProject
{
    public partial class AddressEntry : Form
    {
        ISaveAddress _parent;
        public AddressEntry(ISaveAddress parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            AddressModel address = new AddressModel
            {
                Street = streetTextBox.Text,
                City = cityTextBox.Text,
            };
            _parent.SaveAddress(address);
            this.Close();
        }
    }
}
