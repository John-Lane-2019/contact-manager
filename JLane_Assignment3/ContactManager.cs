using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JLane_Assignment3
{
    public partial class FirstForm : System.Windows.Forms.Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private Contact currentContact = new Contact();

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            SecondForm secondForm = new SecondForm(this); //(this))
            secondForm.Show();
        }

        public void PostContactInfoFromSecondForm(object contact)
        {
            currentContact = (Contact)contact;
            picBox.ImageLocation = currentContact.PhotoFilePath;
            txtFirstName.Text = currentContact.FirstName;
            txtLastName.Text = currentContact.LastName;
            txtAddressType.Text = currentContact.AddressType;
            txtStreet.Text = currentContact.Street;
            txtCity.Text = currentContact.City;
            txtProvince.Text = currentContact.Province;
            txtPostalCode.Text = currentContact.PostalCode;
            txtEmailAddress.Text = currentContact.EmailAddress;
            txtEmailAddressType.Text = currentContact.EmailAddressType;
            txtPhoneNumber.Text = currentContact.PhoneNumber;
            txtPhoneNumberType.Text = currentContact.PhoneNumberType;

            AddContactObjectToListBox(currentContact);
        }

        public void AddContactObjectToListBox(object currentContact)
        {
            listBox.Items.Add(currentContact);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                currentContact = (Contact)listBox.SelectedItem;
                picBox.ImageLocation = currentContact.PhotoFilePath;
                txtFirstName.Text = currentContact.FirstName;
                txtLastName.Text = currentContact.LastName;
                txtAddressType.Text = currentContact.AddressType;
                txtStreet.Text = currentContact.Street;
                txtCity.Text = currentContact.City;
                txtProvince.Text = currentContact.Province;
                txtPostalCode.Text = currentContact.PostalCode;
                txtEmailAddress.Text = currentContact.EmailAddress;
                txtEmailAddressType.Text = currentContact.EmailAddressType;
                txtPhoneNumber.Text = currentContact.PhoneNumber;
                txtPhoneNumberType.Text = currentContact.PhoneNumberType;

                EnableEditButton();
                EnableTakeNoteGroupBox();
            }
        }

        private void EnableEditButton()
        {
            btnEditContact.Enabled = true;
        }

        private void EnableTakeNoteGroupBox()
        {
            grbTakeANote.Enabled = true;
        }

        private void btnEditContact_Click(object sender, EventArgs e)
        {
            SecondForm secondForm = new SecondForm(this);
            secondForm.EditContact(currentContact);
            secondForm.Show();
            listBox.Items.Remove(currentContact);
        }
       
    }
}
