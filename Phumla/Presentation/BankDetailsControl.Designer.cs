namespace Phumla.Presentation
{
    partial class BankDetailsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCardDetails = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.lblCvvError = new System.Windows.Forms.Label();
            this.lblExpiryDateError = new System.Windows.Forms.Label();
            this.lblCardNumberError = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCVV = new System.Windows.Forms.Label();
            this.btnGoBackToAddGuest = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFinaliseGuestAccount = new System.Windows.Forms.Button();
            this.lblAddGuest = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCardDetails
            // 
            this.lblCardDetails.AutoSize = true;
            this.lblCardDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardDetails.Location = new System.Drawing.Point(175, 109);
            this.lblCardDetails.Name = "lblCardDetails";
            this.lblCardDetails.Size = new System.Drawing.Size(164, 29);
            this.lblCardDetails.TabIndex = 41;
            this.lblCardDetails.Text = "Card Details";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(170, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 305);
            this.panel1.TabIndex = 40;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dtpExpiryDate, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtCVV, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblCvvError, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblExpiryDateError, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblCardNumberError, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtCardNumber, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(198, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(303, 281);
            this.tableLayoutPanel2.TabIndex = 36;
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.CustomFormat = "MM/yy";
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpiryDate.Location = new System.Drawing.Point(3, 95);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(87, 22);
            this.dtpExpiryDate.TabIndex = 32;
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(3, 187);
            this.txtCVV.MaxLength = 4;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(93, 22);
            this.txtCVV.TabIndex = 25;
            // 
            // lblCvvError
            // 
            this.lblCvvError.AutoSize = true;
            this.lblCvvError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCvvError.ForeColor = System.Drawing.Color.Crimson;
            this.lblCvvError.Location = new System.Drawing.Point(3, 230);
            this.lblCvvError.Name = "lblCvvError";
            this.lblCvvError.Size = new System.Drawing.Size(85, 22);
            this.lblCvvError.TabIndex = 22;
            this.lblCvvError.Text = "Name(s)";
            // 
            // lblExpiryDateError
            // 
            this.lblExpiryDateError.AutoSize = true;
            this.lblExpiryDateError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDateError.ForeColor = System.Drawing.Color.Crimson;
            this.lblExpiryDateError.Location = new System.Drawing.Point(3, 138);
            this.lblExpiryDateError.Name = "lblExpiryDateError";
            this.lblExpiryDateError.Size = new System.Drawing.Size(85, 22);
            this.lblExpiryDateError.TabIndex = 21;
            this.lblExpiryDateError.Text = "Name(s)";
            // 
            // lblCardNumberError
            // 
            this.lblCardNumberError.AutoSize = true;
            this.lblCardNumberError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumberError.ForeColor = System.Drawing.Color.Crimson;
            this.lblCardNumberError.Location = new System.Drawing.Point(3, 46);
            this.lblCardNumberError.Name = "lblCardNumberError";
            this.lblCardNumberError.Size = new System.Drawing.Size(85, 22);
            this.lblCardNumberError.TabIndex = 20;
            this.lblCardNumberError.Text = "Name(s)";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(3, 3);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(284, 22);
            this.txtCardNumber.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblSurname, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCVV, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(165, 281);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(3, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(117, 22);
            this.lblSurname.TabIndex = 19;
            this.lblSurname.Text = "Card Number";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(3, 93);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(103, 22);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "Expiry Date";
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVV.Location = new System.Drawing.Point(3, 186);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(47, 22);
            this.lblCVV.TabIndex = 23;
            this.lblCVV.Text = "CVV";
            // 
            // btnGoBackToAddGuest
            // 
            this.btnGoBackToAddGuest.Location = new System.Drawing.Point(32, 25);
            this.btnGoBackToAddGuest.Name = "btnGoBackToAddGuest";
            this.btnGoBackToAddGuest.Size = new System.Drawing.Size(75, 23);
            this.btnGoBackToAddGuest.TabIndex = 39;
            this.btnGoBackToAddGuest.Text = "Go Back";
            this.btnGoBackToAddGuest.UseVisualStyleBackColor = true;
            this.btnGoBackToAddGuest.Click += new System.EventHandler(this.btnGoBackToAddGuest_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(170, 439);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 45);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel Creation";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFinaliseGuestAccount
            // 
            this.btnFinaliseGuestAccount.Location = new System.Drawing.Point(536, 439);
            this.btnFinaliseGuestAccount.Name = "btnFinaliseGuestAccount";
            this.btnFinaliseGuestAccount.Size = new System.Drawing.Size(147, 45);
            this.btnFinaliseGuestAccount.TabIndex = 37;
            this.btnFinaliseGuestAccount.Text = "Finalise Guest Account";
            this.btnFinaliseGuestAccount.UseVisualStyleBackColor = true;
            this.btnFinaliseGuestAccount.Click += new System.EventHandler(this.btnFinaliseGuestAccount_Click);
            // 
            // lblAddGuest
            // 
            this.lblAddGuest.AutoSize = true;
            this.lblAddGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGuest.Location = new System.Drawing.Point(192, 25);
            this.lblAddGuest.Name = "lblAddGuest";
            this.lblAddGuest.Size = new System.Drawing.Size(439, 59);
            this.lblAddGuest.TabIndex = 36;
            this.lblAddGuest.Text = "Add Bank Details";
            // 
            // BankDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblCardDetails);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGoBackToAddGuest);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinaliseGuestAccount);
            this.Controls.Add(this.lblAddGuest);
            this.Name = "BankDetailsControl";
            this.Size = new System.Drawing.Size(755, 520);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCardDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label lblCvvError;
        private System.Windows.Forms.Label lblExpiryDateError;
        private System.Windows.Forms.Label lblCardNumberError;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.Button btnGoBackToAddGuest;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFinaliseGuestAccount;
        private System.Windows.Forms.Label lblAddGuest;
    }
}
