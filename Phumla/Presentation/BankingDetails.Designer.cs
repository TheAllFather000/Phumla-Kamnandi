namespace Phumla.Presentation
{
    partial class BankingDetails
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFinaliseGuestAccount = new System.Windows.Forms.Button();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.lblCVV = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddGuest = new System.Windows.Forms.Label();
            this.btnGoBackToAddGuest = new System.Windows.Forms.Button();
            this.cbxCompanyName = new System.Windows.Forms.ComboBox();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(72, 441);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 45);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel Creation";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnFinaliseGuestAccount
            // 
            this.btnFinaliseGuestAccount.Location = new System.Drawing.Point(351, 441);
            this.btnFinaliseGuestAccount.Name = "btnFinaliseGuestAccount";
            this.btnFinaliseGuestAccount.Size = new System.Drawing.Size(147, 45);
            this.btnFinaliseGuestAccount.TabIndex = 28;
            this.btnFinaliseGuestAccount.Text = "Finalise Guest Account";
            this.btnFinaliseGuestAccount.UseVisualStyleBackColor = true;
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(210, 322);
            this.txtCVV.MaxLength = 4;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(93, 22);
            this.txtCVV.TabIndex = 25;
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVV.Location = new System.Drawing.Point(47, 320);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(47, 22);
            this.lblCVV.TabIndex = 23;
            this.lblCVV.Text = "CVV";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(47, 269);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(103, 22);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "Expiry Date";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(210, 216);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(311, 22);
            this.txtCardNumber.TabIndex = 21;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(47, 216);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(117, 22);
            this.lblSurname.TabIndex = 19;
            this.lblSurname.Text = "Card Number";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(47, 170);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(138, 22);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Company Name";
            // 
            // lblAddGuest
            // 
            this.lblAddGuest.AutoSize = true;
            this.lblAddGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGuest.Location = new System.Drawing.Point(59, 51);
            this.lblAddGuest.Name = "lblAddGuest";
            this.lblAddGuest.Size = new System.Drawing.Size(439, 59);
            this.lblAddGuest.TabIndex = 17;
            this.lblAddGuest.Text = "Add Bank Details";
            this.lblAddGuest.Click += new System.EventHandler(this.lblAddGuest_Click);
            // 
            // btnGoBackToAddGuest
            // 
            this.btnGoBackToAddGuest.Location = new System.Drawing.Point(12, 12);
            this.btnGoBackToAddGuest.Name = "btnGoBackToAddGuest";
            this.btnGoBackToAddGuest.Size = new System.Drawing.Size(75, 23);
            this.btnGoBackToAddGuest.TabIndex = 30;
            this.btnGoBackToAddGuest.Text = "Go Back";
            this.btnGoBackToAddGuest.UseVisualStyleBackColor = true;
            // 
            // cbxCompanyName
            // 
            this.cbxCompanyName.AllowDrop = true;
            this.cbxCompanyName.FormattingEnabled = true;
            this.cbxCompanyName.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "Discover"});
            this.cbxCompanyName.Location = new System.Drawing.Point(210, 168);
            this.cbxCompanyName.Name = "cbxCompanyName";
            this.cbxCompanyName.Size = new System.Drawing.Size(187, 24);
            this.cbxCompanyName.TabIndex = 31;
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.CustomFormat = "MM/yy";
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpiryDate.Location = new System.Drawing.Point(210, 269);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(93, 22);
            this.dtpExpiryDate.TabIndex = 32;
            // 
            // BankingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 510);
            this.Controls.Add(this.dtpExpiryDate);
            this.Controls.Add(this.cbxCompanyName);
            this.Controls.Add(this.btnGoBackToAddGuest);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinaliseGuestAccount);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.lblCVV);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAddGuest);
            this.Name = "BankingDetails";
            this.Text = "Guest Banking Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFinaliseGuestAccount;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddGuest;
        private System.Windows.Forms.Button btnGoBackToAddGuest;
        private System.Windows.Forms.ComboBox cbxCompanyName;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
    }
}