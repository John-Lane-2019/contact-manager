namespace JLane_Assignment3
{
    partial class SecondForm
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
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.grbAddress = new System.Windows.Forms.GroupBox();
            this.txtPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.comboProvince = new System.Windows.Forms.ComboBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblAddressType = new System.Windows.Forms.Label();
            this.comboAddressType = new System.Windows.Forms.ComboBox();
            this.grbEmail = new System.Windows.Forms.GroupBox();
            this.comboEmailType = new System.Windows.Forms.ComboBox();
            this.lblEmailType = new System.Windows.Forms.Label();
            this.grbPhone = new System.Windows.Forms.GroupBox();
            this.lblPhoneType = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.comboPhoneType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.grbAddress.SuspendLayout();
            this.grbEmail.SuspendLayout();
            this.grbPhone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(9, 29);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(184, 20);
            this.txtEmailAddress.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(229, 24);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(155, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(229, 76);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(155, 20);
            this.LastName.TabIndex = 1;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(145, 27);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(60, 13);
            this.lblFirstname.TabIndex = 9;
            this.lblFirstname.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(145, 79);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name:";
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Location = new System.Drawing.Point(148, 113);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(75, 23);
            this.btnAddPhoto.TabIndex = 2;
            this.btnAddPhoto.Text = "Add Photo";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.AddPhoto);
            // 
            // grbAddress
            // 
            this.grbAddress.Controls.Add(this.txtPostalCode);
            this.grbAddress.Controls.Add(this.lblPostalCode);
            this.grbAddress.Controls.Add(this.comboProvince);
            this.grbAddress.Controls.Add(this.lblProvince);
            this.grbAddress.Controls.Add(this.lblCity);
            this.grbAddress.Controls.Add(this.txtCity);
            this.grbAddress.Controls.Add(this.txtStreet);
            this.grbAddress.Controls.Add(this.lblStreet);
            this.grbAddress.Controls.Add(this.lblAddressType);
            this.grbAddress.Controls.Add(this.comboAddressType);
            this.grbAddress.Location = new System.Drawing.Point(12, 158);
            this.grbAddress.Name = "grbAddress";
            this.grbAddress.Size = new System.Drawing.Size(377, 125);
            this.grbAddress.TabIndex = 12;
            this.grbAddress.TabStop = false;
            this.grbAddress.Text = "Address:";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(317, 85);
            this.txtPostalCode.Mask = "L0L-0L0";
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(49, 20);
            this.txtPostalCode.TabIndex = 7;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(247, 89);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(67, 13);
            this.lblPostalCode.TabIndex = 11;
            this.lblPostalCode.Text = "Postal Code:";
            // 
            // comboProvince
            // 
            this.comboProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProvince.FormattingEnabled = true;
            this.comboProvince.Items.AddRange(new object[] {
            "AB",
            "BC",
            "MB",
            "NB",
            "NL",
            "NT",
            "NS",
            "NU",
            "ON",
            "PE",
            "QC",
            "SK",
            "YT"});
            this.comboProvince.Location = new System.Drawing.Point(184, 85);
            this.comboProvince.Name = "comboProvince";
            this.comboProvince.Size = new System.Drawing.Size(57, 21);
            this.comboProvince.TabIndex = 6;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(126, 89);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(52, 13);
            this.lblProvince.TabIndex = 9;
            this.lblProvince.Text = "Province:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 89);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(57, 86);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(62, 20);
            this.txtCity.TabIndex = 5;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(57, 51);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(309, 20);
            this.txtStreet.TabIndex = 4;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(6, 54);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 2;
            this.lblStreet.Text = "Street:";
            // 
            // lblAddressType
            // 
            this.lblAddressType.AutoSize = true;
            this.lblAddressType.Location = new System.Drawing.Point(6, 22);
            this.lblAddressType.Name = "lblAddressType";
            this.lblAddressType.Size = new System.Drawing.Size(34, 13);
            this.lblAddressType.TabIndex = 1;
            this.lblAddressType.Text = "Type:";
            // 
            // comboAddressType
            // 
            this.comboAddressType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAddressType.FormattingEnabled = true;
            this.comboAddressType.Items.AddRange(new object[] {
            "Home",
            "Business"});
            this.comboAddressType.Location = new System.Drawing.Point(57, 19);
            this.comboAddressType.Name = "comboAddressType";
            this.comboAddressType.Size = new System.Drawing.Size(121, 21);
            this.comboAddressType.TabIndex = 3;
            // 
            // grbEmail
            // 
            this.grbEmail.Controls.Add(this.comboEmailType);
            this.grbEmail.Controls.Add(this.lblEmailType);
            this.grbEmail.Controls.Add(this.txtEmailAddress);
            this.grbEmail.Location = new System.Drawing.Point(12, 289);
            this.grbEmail.Name = "grbEmail";
            this.grbEmail.Size = new System.Drawing.Size(377, 70);
            this.grbEmail.TabIndex = 13;
            this.grbEmail.TabStop = false;
            this.grbEmail.Text = "Email:";
            // 
            // comboEmailType
            // 
            this.comboEmailType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEmailType.FormattingEnabled = true;
            this.comboEmailType.ItemHeight = 13;
            this.comboEmailType.Items.AddRange(new object[] {
            "Business",
            "Personal"});
            this.comboEmailType.Location = new System.Drawing.Point(255, 29);
            this.comboEmailType.Name = "comboEmailType";
            this.comboEmailType.Size = new System.Drawing.Size(111, 21);
            this.comboEmailType.TabIndex = 9;
            // 
            // lblEmailType
            // 
            this.lblEmailType.AutoSize = true;
            this.lblEmailType.Location = new System.Drawing.Point(207, 31);
            this.lblEmailType.Name = "lblEmailType";
            this.lblEmailType.Size = new System.Drawing.Size(34, 13);
            this.lblEmailType.TabIndex = 5;
            this.lblEmailType.Text = "Type:";
            // 
            // grbPhone
            // 
            this.grbPhone.Controls.Add(this.lblPhoneType);
            this.grbPhone.Controls.Add(this.txtPhoneNumber);
            this.grbPhone.Controls.Add(this.comboPhoneType);
            this.grbPhone.Location = new System.Drawing.Point(13, 365);
            this.grbPhone.Name = "grbPhone";
            this.grbPhone.Size = new System.Drawing.Size(376, 73);
            this.grbPhone.TabIndex = 14;
            this.grbPhone.TabStop = false;
            this.grbPhone.Text = "Phone";
            // 
            // lblPhoneType
            // 
            this.lblPhoneType.AutoSize = true;
            this.lblPhoneType.Location = new System.Drawing.Point(206, 35);
            this.lblPhoneType.Name = "lblPhoneType";
            this.lblPhoneType.Size = new System.Drawing.Size(34, 13);
            this.lblPhoneType.TabIndex = 9;
            this.lblPhoneType.Text = "Type:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(8, 33);
            this.txtPhoneNumber.Mask = "(000) 000-0000";
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(184, 20);
            this.txtPhoneNumber.TabIndex = 10;
            // 
            // comboPhoneType
            // 
            this.comboPhoneType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPhoneType.FormattingEnabled = true;
            this.comboPhoneType.Items.AddRange(new object[] {
            "Business",
            "Personal"});
            this.comboPhoneType.Location = new System.Drawing.Point(254, 32);
            this.comboPhoneType.Name = "comboPhoneType";
            this.comboPhoneType.Size = new System.Drawing.Size(111, 21);
            this.comboPhoneType.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(314, 447);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picBox2
            // 
            this.picBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox2.Image = global::JLane_Assignment3.Properties.Resources.iconfinder_b_95_42302871;
            this.picBox2.Location = new System.Drawing.Point(12, 12);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(116, 124);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox2.TabIndex = 3;
            this.picBox2.TabStop = false;
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 482);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbPhone);
            this.Controls.Add(this.grbEmail);
            this.Controls.Add(this.grbAddress);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.picBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SecondForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Contact";
            this.grbAddress.ResumeLayout(false);
            this.grbAddress.PerformLayout();
            this.grbEmail.ResumeLayout(false);
            this.grbEmail.PerformLayout();
            this.grbPhone.ResumeLayout(false);
            this.grbPhone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.GroupBox grbAddress;
        private System.Windows.Forms.Label lblAddressType;
        private System.Windows.Forms.ComboBox comboAddressType;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.GroupBox grbEmail;
        private System.Windows.Forms.Label lblEmailType;
        private System.Windows.Forms.MaskedTextBox txtPostalCode;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.ComboBox comboProvince;
        private System.Windows.Forms.ComboBox comboEmailType;
        private System.Windows.Forms.GroupBox grbPhone;
        private System.Windows.Forms.Label lblPhoneType;
        private System.Windows.Forms.MaskedTextBox txtPhoneNumber;
        private System.Windows.Forms.ComboBox comboPhoneType;
        private System.Windows.Forms.Button btnSave;
    }
}