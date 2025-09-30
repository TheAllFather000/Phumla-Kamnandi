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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblIDError = new System.Windows.Forms.Label();
            this.lblDoBError = new System.Windows.Forms.Label();
            this.lblSurnameError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblCardDetails = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 488);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 45);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel Creation";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFinaliseGuestAccount
            // 
            this.btnFinaliseGuestAccount.Location = new System.Drawing.Point(378, 488);
            this.btnFinaliseGuestAccount.Name = "btnFinaliseGuestAccount";
            this.btnFinaliseGuestAccount.Size = new System.Drawing.Size(147, 45);
            this.btnFinaliseGuestAccount.TabIndex = 28;
            this.btnFinaliseGuestAccount.Text = "Finalise Guest Account";
            this.btnFinaliseGuestAccount.UseVisualStyleBackColor = true;
            this.btnFinaliseGuestAccount.Click += new System.EventHandler(this.btnFinaliseGuestAccount_Click);
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(3, 213);
            this.txtCVV.MaxLength = 4;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(93, 22);
            this.txtCVV.TabIndex = 25;
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVV.Location = new System.Drawing.Point(3, 210);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(47, 22);
            this.lblCVV.TabIndex = 23;
            this.lblCVV.Text = "CVV";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(3, 140);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(103, 22);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "Expiry Date";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(3, 73);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(284, 22);
            this.txtCardNumber.TabIndex = 21;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(3, 70);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(117, 22);
            this.lblSurname.TabIndex = 19;
            this.lblSurname.Text = "Card Number";
            this.lblSurname.Click += new System.EventHandler(this.lblSurname_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(138, 22);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Company Name";
            // 
            // lblAddGuest
            // 
            this.lblAddGuest.AutoSize = true;
            this.lblAddGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGuest.Location = new System.Drawing.Point(19, 71);
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
            this.btnGoBackToAddGuest.Click += new System.EventHandler(this.btnGoBackToAddGuest_Click);
            // 
            // cbxCompanyName
            // 
            this.cbxCompanyName.AllowDrop = true;
            this.cbxCompanyName.FormattingEnabled = true;
            this.cbxCompanyName.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "Discover"});
            this.cbxCompanyName.Location = new System.Drawing.Point(3, 3);
            this.cbxCompanyName.Name = "cbxCompanyName";
            this.cbxCompanyName.Size = new System.Drawing.Size(204, 24);
            this.cbxCompanyName.TabIndex = 31;
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.CustomFormat = "MM/yy";
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpiryDate.Location = new System.Drawing.Point(3, 143);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(87, 22);
            this.dtpExpiryDate.TabIndex = 32;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSurname, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCVV, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(165, 281);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 305);
            this.panel1.TabIndex = 34;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dtpExpiryDate, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.cbxCompanyName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtCVV, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblIDError, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblDoBError, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblSurnameError, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblNameError, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtCardNumber, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(198, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(303, 281);
            this.tableLayoutPanel2.TabIndex = 36;
            // 
            // lblIDError
            // 
            this.lblIDError.AutoSize = true;
            this.lblIDError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDError.ForeColor = System.Drawing.Color.Crimson;
            this.lblIDError.Location = new System.Drawing.Point(3, 245);
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
            this.lblDoBError.Location = new System.Drawing.Point(3, 175);
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
            this.lblSurnameError.Location = new System.Drawing.Point(3, 105);
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
            this.lblNameError.Location = new System.Drawing.Point(3, 35);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(85, 22);
            this.lblNameError.TabIndex = 19;
            this.lblNameError.Text = "Name(s)";
            // 
            // lblCardDetails
            // 
            this.lblCardDetails.AutoSize = true;
            this.lblCardDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardDetails.Location = new System.Drawing.Point(17, 158);
            this.lblCardDetails.Name = "lblCardDetails";
            this.lblCardDetails.Size = new System.Drawing.Size(164, 29);
            this.lblCardDetails.TabIndex = 35;
            this.lblCardDetails.Text = "Card Details";
            // 
            // BankingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 554);
            this.Controls.Add(this.lblCardDetails);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGoBackToAddGuest);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinaliseGuestAccount);
            this.Controls.Add(this.lblAddGuest);
            this.Name = "BankingDetails";
            this.Text = "Guest Banking Details";
            this.Load += new System.EventHandler(this.BankingDetails_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCardDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblIDError;
        private System.Windows.Forms.Label lblDoBError;
        private System.Windows.Forms.Label lblSurnameError;
        private System.Windows.Forms.Label lblNameError;
    }
}