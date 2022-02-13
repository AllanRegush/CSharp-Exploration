using System;
using System.ComponentModel;
using System.Windows.Forms;
using WinFormsMiniProjectLibrary;
using WinFormsMiniProjectLibrary.Models;

namespace WinFormMiniProject
{
    public partial class PersonEntry : Form, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();
        public PersonEntry()
        {
            InitializeComponent();

            addressListBox.DataSource = addresses;
            addressListBox.DisplayMember = nameof(AddressModel.DisplayFullAddressValue);
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addressEntry = new AddressEntry(this);
            addressEntry.Show();
        }
    }
}
