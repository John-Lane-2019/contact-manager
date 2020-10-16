namespace JLane_Assignment3
{
    partial class FirstForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnEditContact = new System.Windows.Forms.Button();
            this.grbTakeANote = new System.Windows.Forms.GroupBox();
            this.txtTakeANote = new System.Windows.Forms.TextBox();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.grbNotes = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.grbAddress = new System.Windows.Forms.GroupBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtAddressType = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.grbEmail = new System.Windows.Forms.GroupBox();
            this.txtEmailAddressType = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmailType = new System.Windows.Forms.Label();
            this.grbPhone = new System.Windows.Forms.GroupBox();
            this.txtPhoneNumberType = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.grbTakeANote.SuspendLayout();
            this.grbNotes.SuspendLayout();
            this.grbAddress.SuspendLayout();
            this.grbEmail.SuspendLayout();
            this.grbPhone.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 20);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(146, 381);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(12, 408);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(146, 30);
            this.btnAddContact.TabIndex = 1;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Enabled = false;
            this.picBox.Image = global::JLane_Assignment3.Properties.Resources.iconfinder_b_95_42302871;
            this.picBox.Location = new System.Drawing.Point(179, 20);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(116, 124);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Enabled = false;
            this.lblFirstName.Location = new System.Drawing.Point(301, 50);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Enabled = false;
            this.lblLastName.Location = new System.Drawing.Point(301, 87);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(363, 47);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(132, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(363, 84);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(132, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // btnEditContact
            // 
            this.btnEditContact.Enabled = false;
            this.btnEditContact.Location = new System.Drawing.Point(410, 121);
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Size = new System.Drawing.Size(85, 23);
            this.btnEditContact.TabIndex = 7;
            this.btnEditContact.Text = "Edit Contact";
            this.btnEditContact.UseVisualStyleBackColor = true;
            this.btnEditContact.Click += new System.EventHandler(this.btnEditContact_Click);
            // 
            // grbTakeANote
            // 
            this.grbTakeANote.Controls.Add(this.txtTakeANote);
            this.grbTakeANote.Controls.Add(this.btnAddNote);
            this.grbTakeANote.Enabled = false;
            this.grbTakeANote.Location = new System.Drawing.Point(555, 20);
            this.grbTakeANote.Name = "grbTakeANote";
            this.grbTakeANote.Size = new System.Drawing.Size(319, 124);
            this.grbTakeANote.TabIndex = 8;
            this.grbTakeANote.TabStop = false;
            this.grbTakeANote.Text = "Take A Note:";
            // 
            // txtTakeANote
            // 
            this.txtTakeANote.Location = new System.Drawing.Point(6, 19);
            this.txtTakeANote.Multiline = true;
            this.txtTakeANote.Name = "txtTakeANote";
            this.txtTakeANote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTakeANote.Size = new System.Drawing.Size(307, 70);
            this.txtTakeANote.TabIndex = 9;
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(238, 95);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(75, 23);
            this.btnAddNote.TabIndex = 0;
            this.btnAddNote.Text = "Add Note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            // 
            // grbNotes
            // 
            this.grbNotes.Controls.Add(this.txtNotes);
            this.grbNotes.Enabled = false;
            this.grbNotes.Location = new System.Drawing.Point(555, 150);
            this.grbNotes.Name = "grbNotes";
            this.grbNotes.Size = new System.Drawing.Size(319, 288);
            this.grbNotes.TabIndex = 9;
            this.grbNotes.TabStop = false;
            this.grbNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Enabled = false;
            this.txtNotes.Location = new System.Drawing.Point(6, 19);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(306, 262);
            this.txtNotes.TabIndex = 0;
            // 
            // grbAddress
            // 
            this.grbAddress.Controls.Add(this.txtPostalCode);
            this.grbAddress.Controls.Add(this.txtProvince);
            this.grbAddress.Controls.Add(this.txtCity);
            this.grbAddress.Controls.Add(this.txtStreet);
            this.grbAddress.Controls.Add(this.txtAddressType);
            this.grbAddress.Controls.Add(this.lblPostalCode);
            this.grbAddress.Controls.Add(this.lblProvince);
            this.grbAddress.Controls.Add(this.lblCity);
            this.grbAddress.Controls.Add(this.lblStreet);
            this.grbAddress.Controls.Add(this.lblType);
            this.grbAddress.Enabled = false;
            this.grbAddress.Location = new System.Drawing.Point(179, 150);
            this.grbAddress.Name = "grbAddress";
            this.grbAddress.Size = new System.Drawing.Size(351, 156);
            this.grbAddress.TabIndex = 10;
            this.grbAddress.TabStop = false;
            this.grbAddress.Text = "Address:";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(279, 103);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.ReadOnly = true;
            this.txtPostalCode.Size = new System.Drawing.Size(66, 20);
            this.txtPostalCode.TabIndex = 8;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(175, 103);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.ReadOnly = true;
            this.txtProvince.Size = new System.Drawing.Size(33, 20);
            this.txtProvince.TabIndex = 7;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(49, 104);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(62, 20);
            this.txtCity.TabIndex = 6;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(49, 67);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(296, 20);
            this.txtStreet.TabIndex = 5;
            // 
            // txtAddressType
            // 
            this.txtAddressType.Location = new System.Drawing.Point(49, 31);
            this.txtAddressType.Name = "txtAddressType";
            this.txtAddressType.ReadOnly = true;
            this.txtAddressType.Size = new System.Drawing.Size(100, 20);
            this.txtAddressType.TabIndex = 1;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(214, 107);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(67, 13);
            this.lblPostalCode.TabIndex = 4;
            this.lblPostalCode.Text = "Postal Code:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(117, 106);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(52, 13);
            this.lblProvince.TabIndex = 3;
            this.lblProvince.Text = "Province:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(7, 107);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(7, 70);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 1;
            this.lblStreet.Text = "Street:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 31);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type:";
            // 
            // grbEmail
            // 
            this.grbEmail.Controls.Add(this.txtEmailAddressType);
            this.grbEmail.Controls.Add(this.txtEmailAddress);
            this.grbEmail.Controls.Add(this.lblEmailType);
            this.grbEmail.Enabled = false;
            this.grbEmail.Location = new System.Drawing.Point(179, 312);
            this.grbEmail.Name = "grbEmail";
            this.grbEmail.Size = new System.Drawing.Size(351, 58);
            this.grbEmail.TabIndex = 11;
            this.grbEmail.TabStop = false;
            this.grbEmail.Text = "Email:";
            // 
            // txtEmailAddressType
            // 
            this.txtEmailAddressType.Location = new System.Drawing.Point(239, 19);
            this.txtEmailAddressType.Name = "txtEmailAddressType";
            this.txtEmailAddressType.ReadOnly = true;
            this.txtEmailAddressType.Size = new System.Drawing.Size(106, 20);
            this.txtEmailAddressType.TabIndex = 2;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(10, 20);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.ReadOnly = true;
            this.txtEmailAddress.Size = new System.Drawing.Size(180, 20);
            this.txtEmailAddress.TabIndex = 1;
            // 
            // lblEmailType
            // 
            this.lblEmailType.AutoSize = true;
            this.lblEmailType.Location = new System.Drawing.Point(199, 23);
            this.lblEmailType.Name = "lblEmailType";
            this.lblEmailType.Size = new System.Drawing.Size(34, 13);
            this.lblEmailType.TabIndex = 0;
            this.lblEmailType.Text = "Type:";
            // 
            // grbPhone
            // 
            this.grbPhone.Controls.Add(this.txtPhoneNumberType);
            this.grbPhone.Controls.Add(this.txtPhoneNumber);
            this.grbPhone.Controls.Add(this.lblPhoneType);
            this.grbPhone.Enabled = false;
            this.grbPhone.Location = new System.Drawing.Point(179, 376);
            this.grbPhone.Name = "grbPhone";
            this.grbPhone.Size = new System.Drawing.Size(351, 62);
            this.grbPhone.TabIndex = 12;
            this.grbPhone.TabStop = false;
            this.grbPhone.Text = "Phone";
            // 
            // txtPhoneNumberType
            // 
            this.txtPhoneNumberType.Location = new System.Drawing.Point(239, 17);
            this.txtPhoneNumberType.Name = "txtPhoneNumberType";
            this.txtPhoneNumberType.ReadOnly = true;
            this.txtPhoneNumberType.Size = new System.Drawing.Size(106, 20);
            this.txtPhoneNumberType.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(9, 20);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(184, 20);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // lblPhoneType
            // 
            this.lblPhoneType.AutoSize = true;
            this.lblPhoneType.Location = new System.Drawing.Point(202, 20);
            this.lblPhoneType.Name = "lblPhoneType";
            this.lblPhoneType.Size = new System.Drawing.Size(34, 13);
            this.lblPhoneType.TabIndex = 0;
            this.lblPhoneType.Text = "Type:";
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 461);
            this.Controls.Add(this.grbPhone);
            this.Controls.Add(this.grbEmail);
            this.Controls.Add(this.grbAddress);
            this.Controls.Add(this.grbNotes);
            this.Controls.Add(this.grbTakeANote);
            this.Controls.Add(this.btnEditContact);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.listBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FirstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Manager";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.grbTakeANote.ResumeLayout(false);
            this.grbTakeANote.PerformLayout();
            this.grbNotes.ResumeLayout(false);
            this.grbNotes.PerformLayout();
            this.grbAddress.ResumeLayout(false);
            this.grbAddress.PerformLayout();
            this.grbEmail.ResumeLayout(false);
            this.grbEmail.PerformLayout();
            this.grbPhone.ResumeLayout(false);
            this.grbPhone.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnEditContact;
        private System.Windows.Forms.GroupBox grbTakeANote;
        private System.Windows.Forms.TextBox txtTakeANote;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.GroupBox grbNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.GroupBox grbAddress;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtAddressType;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.GroupBox grbEmail;
        private System.Windows.Forms.Label lblEmailType;
        private System.Windows.Forms.GroupBox grbPhone;
        private System.Windows.Forms.Label lblPhoneType;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtEmailAddressType;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtPhoneNumberType;
        private System.Windows.Forms.TextBox txtPhoneNumber;
    }
}

