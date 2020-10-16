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
    public partial class SecondForm : Form
    {
        //private Contact[] contact = new Contact[1];
        private FirstForm firstForm;
       
        public SecondForm(FirstForm firstForm)
        {
            InitializeComponent();
            this.firstForm = firstForm;
        }

        private Contact contact = new Contact();

        public void EditContact(object currentContact)
        {
            contact = (Contact)currentContact;
            picBox2.ImageLocation = contact.PhotoFilePath;
            txtFirstName.Text = contact.FirstName;
            LastName.Text = contact.LastName;
            comboAddressType.Text = contact.AddressType;
            txtStreet.Text = contact.Street;
            txtCity.Text = contact.City;
            comboProvince.Text = contact.Province;
            txtPostalCode.Text = contact.PostalCode;
            txtEmailAddress.Text = contact.EmailAddress;
            comboEmailType.Text = contact.EmailAddressType;
            txtPhoneNumber.Text = contact.PhoneNumber;
            comboPhoneType.Text = contact.PhoneNumberType;
            //firstForm.ClearListBox();
        }


        private void AddPhoto(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.AddExtension = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Filter = "JPEG(.jpg)|*.jpg|PNG(*.png)|*.png";

            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                contact.PhotoFilePath = openFileDialog.FileName;
                picBox2.ImageLocation = contact.PhotoFilePath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            contact.FirstName = txtFirstName.Text;
            contact.LastName = LastName.Text;
            contact.AddressType = comboAddressType.Text;
            contact.Street = txtStreet.Text;
            contact.City = txtCity.Text;
            contact.Province = comboProvince.Text;
            contact.PostalCode = txtPostalCode.Text.ToUpper();
            contact.EmailAddress = txtEmailAddress.Text;
            contact.EmailAddressType = comboEmailType.Text;
            contact.PhoneNumber = txtPhoneNumber.Text;
            contact.PhoneNumberType = comboPhoneType.Text;


            if (txtFirstName.Text == "" || LastName.Text == "")
            {
                MessageBox.Show("Please note that first name and second name are mandatory fields.");
            }
            else
            {
                
                firstForm.PostContactInfoFromSecondForm(contact);
                
            }
            Close();
        }

       
    }
}
