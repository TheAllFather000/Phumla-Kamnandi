namespace Phumla.Presentation
{
    partial class AddGuest
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
            this.lblAddGuestAccount = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnAddBankingDetails = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDOB = new System.Windows.Forms.Label();
            this.tpnlPersonalDetails = new System.Windows.Forms.TableLayoutPanel();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.tpnlBillingAddress = new System.Windows.Forms.TableLayoutPanel();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.pnlPersonalDetails = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPhoneNumberError = new System.Windows.Forms.Label();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblIDError = new System.Windows.Forms.Label();
            this.lblDoBError = new System.Windows.Forms.Label();
            this.lblSurnameError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.pnlBillingAddress = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.lblCountryError = new System.Windows.Forms.Label();
            this.lblPostalCodeError = new System.Windows.Forms.Label();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.lblSuburbError = new System.Windows.Forms.Label();
            this.lblCityError = new System.Windows.Forms.Label();
            this.lblStreetNameError = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblPersonalDetails = new System.Windows.Forms.Label();
            this.lblBillingAddress = new System.Windows.Forms.Label();
            this.btnFinaliseGuestAccount = new System.Windows.Forms.Button();
            this.tpnlPersonalDetails.SuspendLayout();
            this.tpnlBillingAddress.SuspendLayout();
            this.pnlPersonalDetails.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlBillingAddress.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddGuestAccount
            // 
            this.lblAddGuestAccount.AutoSize = true;
            this.lblAddGuestAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGuestAccount.Location = new System.Drawing.Point(30, 22);
            this.lblAddGuestAccount.Name = "lblAddGuestAccount";
            this.lblAddGuestAccount.Size = new System.Drawing.Size(489, 59);
            this.lblAddGuestAccount.TabIndex = 0;
            this.lblAddGuestAccount.Text = "Add Guest Account";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(3, 59);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(311, 22);
            this.txtSurname.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(3, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(311, 22);
            this.txtName.TabIndex = 7;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(3, 56);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(82, 22);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 22);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name(s)";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(3, 227);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(311, 22);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(3, 171);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(409, 22);
            this.txtID.TabIndex = 11;
            this.txtID.Text = "Must be grey if age < 16";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(3, 224);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 22);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(3, 168);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 22);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(3, 283);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(311, 22);
            this.txtPhoneNumber.TabIndex = 14;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(3, 280);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(159, 22);
            this.lblPhoneNumber.TabIndex = 13;
            this.lblPhoneNumber.Text = "[M] Phone Number";
            this.lblPhoneNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddBankingDetails
            // 
            this.btnAddBankingDetails.Location = new System.Drawing.Point(519, 961);
            this.btnAddBankingDetails.Name = "btnAddBankingDetails";
            this.btnAddBankingDetails.Size = new System.Drawing.Size(147, 45);
            this.btnAddBankingDetails.TabIndex = 15;
            this.btnAddBankingDetails.Text = "Add Banking Details";
            this.btnAddBankingDetails.UseVisualStyleBackColor = true;
            this.btnAddBankingDetails.Click += new System.EventHandler(this.btnAddBankingDetails_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(40, 961);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 45);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel Creation";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(3, 112);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(110, 22);
            this.lblDOB.TabIndex = 17;
            this.lblDOB.Text = "Date of Birth";
            // 
            // tpnlPersonalDetails
            // 
            this.tpnlPersonalDetails.ColumnCount = 1;
            this.tpnlPersonalDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpnlPersonalDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tpnlPersonalDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tpnlPersonalDetails.Controls.Add(this.lblName, 0, 0);
            this.tpnlPersonalDetails.Controls.Add(this.lblDOB, 0, 2);
            this.tpnlPersonalDetails.Controls.Add(this.lblSurname, 0, 1);
            this.tpnlPersonalDetails.Controls.Add(this.lblID, 0, 3);
            this.tpnlPersonalDetails.Controls.Add(this.lblPhoneNumber, 0, 5);
            this.tpnlPersonalDetails.Controls.Add(this.lblEmail, 0, 4);
            this.tpnlPersonalDetails.Location = new System.Drawing.Point(3, 20);
            this.tpnlPersonalDetails.Name = "tpnlPersonalDetails";
            this.tpnlPersonalDetails.RowCount = 6;
            this.tpnlPersonalDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tpnlPersonalDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tpnlPersonalDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tpnlPersonalDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tpnlPersonalDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tpnlPersonalDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tpnlPersonalDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlPersonalDetails.Size = new System.Drawing.Size(183, 342);
            this.tpnlPersonalDetails.TabIndex = 19;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(3, 115);
            this.dtpDOB.MaxDate = new System.DateTime(2025, 9, 30, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1925, 12, 25, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(242, 22);
            this.dtpDOB.TabIndex = 18;
            this.dtpDOB.Value = new System.DateTime(2025, 9, 30, 0, 0, 0, 0);
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // tpnlBillingAddress
            // 
            this.tpnlBillingAddress.ColumnCount = 1;
            this.tpnlBillingAddress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.1531F));
            this.tpnlBillingAddress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.84691F));
            this.tpnlBillingAddress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlBillingAddress.Controls.Add(this.lblStreetName, 0, 0);
            this.tpnlBillingAddress.Controls.Add(this.lblSuburb, 0, 1);
            this.tpnlBillingAddress.Controls.Add(this.lblPostalCode, 0, 3);
            this.tpnlBillingAddress.Controls.Add(this.lblCountry, 0, 4);
            this.tpnlBillingAddress.Controls.Add(this.lblCity, 0, 2);
            this.tpnlBillingAddress.Location = new System.Drawing.Point(3, 12);
            this.tpnlBillingAddress.Name = "tpnlBillingAddress";
            this.tpnlBillingAddress.RowCount = 5;
            this.tpnlBillingAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tpnlBillingAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tpnlBillingAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tpnlBillingAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tpnlBillingAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tpnlBillingAddress.Size = new System.Drawing.Size(183, 342);
            this.tpnlBillingAddress.TabIndex = 20;
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetName.Location = new System.Drawing.Point(3, 0);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(110, 22);
            this.lblStreetName.TabIndex = 5;
            this.lblStreetName.Text = "Street Name";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuburb.Location = new System.Drawing.Point(3, 68);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(68, 22);
            this.lblSuburb.TabIndex = 17;
            this.lblSuburb.Text = "Suburb";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(3, 136);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(41, 22);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCode.Location = new System.Drawing.Point(3, 204);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(108, 22);
            this.lblPostalCode.TabIndex = 9;
            this.lblPostalCode.Text = "Postal Code";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(3, 272);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(73, 22);
            this.lblCountry.TabIndex = 10;
            this.lblCountry.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(3, 275);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(409, 22);
            this.txtCountry.TabIndex = 12;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(3, 207);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(353, 22);
            this.txtPostalCode.TabIndex = 11;
            // 
            // pnlPersonalDetails
            // 
            this.pnlPersonalDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPersonalDetails.Controls.Add(this.tableLayoutPanel1);
            this.pnlPersonalDetails.Controls.Add(this.tpnlPersonalDetails);
            this.pnlPersonalDetails.Location = new System.Drawing.Point(40, 134);
            this.pnlPersonalDetails.Name = "pnlPersonalDetails";
            this.pnlPersonalDetails.Size = new System.Drawing.Size(626, 368);
            this.pnlPersonalDetails.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblPhoneNumberError, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.lblEmailError, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblIDError, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblDoBError, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSurnameError, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblNameError, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPhoneNumber, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.dtpDOB, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtSurname, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(204, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(415, 342);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // lblPhoneNumberError
            // 
            this.lblPhoneNumberError.AutoSize = true;
            this.lblPhoneNumberError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumberError.ForeColor = System.Drawing.Color.Crimson;
            this.lblPhoneNumberError.Location = new System.Drawing.Point(3, 308);
            this.lblPhoneNumberError.Name = "lblPhoneNumberError";
            this.lblPhoneNumberError.Size = new System.Drawing.Size(85, 22);
            this.lblPhoneNumberError.TabIndex = 24;
            this.lblPhoneNumberError.Text = "Name(s)";
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailError.ForeColor = System.Drawing.Color.Crimson;
            this.lblEmailError.Location = new System.Drawing.Point(3, 252);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(85, 22);
            this.lblEmailError.TabIndex = 23;
            this.lblEmailError.Text = "Name(s)";
            // 
            // lblIDError
            // 
            this.lblIDError.AutoSize = true;
            this.lblIDError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDError.ForeColor = System.Drawing.Color.Crimson;
            this.lblIDError.Location = new System.Drawing.Point(3, 196);
            this.lblIDError.Name = "lblIDError";
            this.lblIDError.Size = new System.Drawing.Size(85, 22);
            this.lblIDError.TabIndex = 22;
            this.lblIDError.Text = "Name(s)";
            // 
            // lblDoBError
            // 
            this.lblDoBError.AutoSize = true;
            this.lblDoBError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoBError.ForeColor = System.Drawing.Color.Crimson;
            this.lblDoBError.Location = new System.Drawing.Point(3, 140);
            this.lblDoBError.Name = "lblDoBError";
            this.lblDoBError.Size = new System.Drawing.Size(85, 22);
            this.lblDoBError.TabIndex = 21;
            this.lblDoBError.Text = "Name(s)";
            // 
            // lblSurnameError
            // 
            this.lblSurnameError.AutoSize = true;
            this.lblSurnameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnameError.ForeColor = System.Drawing.Color.Crimson;
            this.lblSurnameError.Location = new System.Drawing.Point(3, 84);
            this.lblSurnameError.Name = "lblSurnameError";
            this.lblSurnameError.Size = new System.Drawing.Size(85, 22);
            this.lblSurnameError.TabIndex = 20;
            this.lblSurnameError.Text = "Name(s)";
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameError.ForeColor = System.Drawing.Color.Crimson;
            this.lblNameError.Location = new System.Drawing.Point(3, 28);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(85, 22);
            this.lblNameError.TabIndex = 19;
            this.lblNameError.Text = "Name(s)";
            // 
            // pnlBillingAddress
            // 
            this.pnlBillingAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBillingAddress.Controls.Add(this.tableLayoutPanel2);
            this.pnlBillingAddress.Controls.Add(this.tpnlBillingAddress);
            this.pnlBillingAddress.Location = new System.Drawing.Point(40, 577);
            this.pnlBillingAddress.Name = "pnlBillingAddress";
            this.pnlBillingAddress.Size = new System.Drawing.Size(626, 363);
            this.pnlBillingAddress.TabIndex = 22;
            this.pnlBillingAddress.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBillingAddress_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtSuburb, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblCountryError, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.txtCountry, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.lblPostalCodeError, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblSuburbError, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtStreetName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtPostalCode, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblStreetNameError, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCityError, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtCity, 0, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(204, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(415, 342);
            this.tableLayoutPanel2.TabIndex = 39;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(3, 71);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(409, 22);
            this.txtSuburb.TabIndex = 18;
            // 
            // lblCountryError
            // 
            this.lblCountryError.AutoSize = true;
            this.lblCountryError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryError.ForeColor = System.Drawing.Color.Crimson;
            this.lblCountryError.Location = new System.Drawing.Point(3, 306);
            this.lblCountryError.Name = "lblCountryError";
            this.lblCountryError.Size = new System.Drawing.Size(85, 22);
            this.lblCountryError.TabIndex = 23;
            this.lblCountryError.Text = "Name(s)";
            // 
            // lblPostalCodeError
            // 
            this.lblPostalCodeError.AutoSize = true;
            this.lblPostalCodeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCodeError.ForeColor = System.Drawing.Color.Crimson;
            this.lblPostalCodeError.Location = new System.Drawing.Point(3, 238);
            this.lblPostalCodeError.Name = "lblPostalCodeError";
            this.lblPostalCodeError.Size = new System.Drawing.Size(85, 22);
            this.lblPostalCodeError.TabIndex = 22;
            this.lblPostalCodeError.Text = "Name(s)";
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(3, 3);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(409, 22);
            this.txtStreetName.TabIndex = 7;
            // 
            // lblSuburbError
            // 
            this.lblSuburbError.AutoSize = true;
            this.lblSuburbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuburbError.ForeColor = System.Drawing.Color.Crimson;
            this.lblSuburbError.Location = new System.Drawing.Point(3, 102);
            this.lblSuburbError.Name = "lblSuburbError";
            this.lblSuburbError.Size = new System.Drawing.Size(85, 22);
            this.lblSuburbError.TabIndex = 21;
            this.lblSuburbError.Text = "Name(s)";
            // 
            // lblCityError
            // 
            this.lblCityError.AutoSize = true;
            this.lblCityError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityError.ForeColor = System.Drawing.Color.Crimson;
            this.lblCityError.Location = new System.Drawing.Point(3, 170);
            this.lblCityError.Name = "lblCityError";
            this.lblCityError.Size = new System.Drawing.Size(85, 22);
            this.lblCityError.TabIndex = 20;
            this.lblCityError.Text = "Name(s)";
            // 
            // lblStreetNameError
            // 
            this.lblStreetNameError.AutoSize = true;
            this.lblStreetNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetNameError.ForeColor = System.Drawing.Color.Crimson;
            this.lblStreetNameError.Location = new System.Drawing.Point(3, 34);
            this.lblStreetNameError.Name = "lblStreetNameError";
            this.lblStreetNameError.Size = new System.Drawing.Size(85, 22);
            this.lblStreetNameError.TabIndex = 19;
            this.lblStreetNameError.Text = "Name(s)";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(3, 139);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(409, 22);
            this.txtCity.TabIndex = 8;
            // 
            // lblPersonalDetails
            // 
            this.lblPersonalDetails.AutoSize = true;
            this.lblPersonalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalDetails.Location = new System.Drawing.Point(48, 113);
            this.lblPersonalDetails.Name = "lblPersonalDetails";
            this.lblPersonalDetails.Size = new System.Drawing.Size(214, 29);
            this.lblPersonalDetails.TabIndex = 36;
            this.lblPersonalDetails.Text = "Personal Details";
            // 
            // lblBillingAddress
            // 
            this.lblBillingAddress.AutoSize = true;
            this.lblBillingAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillingAddress.Location = new System.Drawing.Point(48, 558);
            this.lblBillingAddress.Name = "lblBillingAddress";
            this.lblBillingAddress.Size = new System.Drawing.Size(197, 29);
            this.lblBillingAddress.TabIndex = 37;
            this.lblBillingAddress.Text = "Billing Address";
            // 
            // btnFinaliseGuestAccount
            // 
            this.btnFinaliseGuestAccount.Location = new System.Drawing.Point(252, 961);
            this.btnFinaliseGuestAccount.Name = "btnFinaliseGuestAccount";
            this.btnFinaliseGuestAccount.Size = new System.Drawing.Size(147, 45);
            this.btnFinaliseGuestAccount.TabIndex = 38;
            this.btnFinaliseGuestAccount.Text = "Finalise Guest Account";
            this.btnFinaliseGuestAccount.UseVisualStyleBackColor = true;
            this.btnFinaliseGuestAccount.Click += new System.EventHandler(this.btnFinaliseGuestAccount_Click);
            // 
            // AddGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(740, 1055);
            this.Controls.Add(this.btnFinaliseGuestAccount);
            this.Controls.Add(this.lblBillingAddress);
            this.Controls.Add(this.lblPersonalDetails);
            this.Controls.Add(this.pnlBillingAddress);
            this.Controls.Add(this.pnlPersonalDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddBankingDetails);
            this.Controls.Add(this.lblAddGuestAccount);
            this.Name = "AddGuest";
            this.Text = "Add a Guest";
            this.Load += new System.EventHandler(this.AddGuest_Load);
            this.tpnlPersonalDetails.ResumeLayout(false);
            this.tpnlPersonalDetails.PerformLayout();
            this.tpnlBillingAddress.ResumeLayout(false);
            this.tpnlBillingAddress.PerformLayout();
            this.pnlPersonalDetails.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlBillingAddress.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddGuestAccount;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnAddBankingDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TableLayoutPanel tpnlPersonalDetails;
        private System.Windows.Forms.TableLayoutPanel tpnlBillingAddress;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Panel pnlPersonalDetails;
        private System.Windows.Forms.Panel pnlBillingAddress;
        private System.Windows.Forms.Label lblPersonalDetails;
        private System.Windows.Forms.Label lblBillingAddress;
        private System.Windows.Forms.Button btnFinaliseGuestAccount;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPhoneNumberError;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblIDError;
        private System.Windows.Forms.Label lblDoBError;
        private System.Windows.Forms.Label lblSurnameError;
        private System.Windows.Forms.Label lblNameError;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.Label lblCountryError;
        private System.Windows.Forms.Label lblPostalCodeError;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.Label lblSuburbError;
        private System.Windows.Forms.Label lblCityError;
        private System.Windows.Forms.Label lblStreetNameError;
        private System.Windows.Forms.TextBox txtCity;
    }
}