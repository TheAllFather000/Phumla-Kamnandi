namespace Phumla.Presentation
{
    partial class CreateReservation
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
            this.lblCreateReservation = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.pnlCreateReservation = new System.Windows.Forms.Panel();
            this.lsvCreateReservation = new System.Windows.Forms.ListView();
            this.btnConfirmRegistration = new System.Windows.Forms.Button();
            this.btnGoBackToAddGuest = new System.Windows.Forms.Button();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.lblHotelID = new System.Windows.Forms.Label();
            this.txtHotelID = new System.Windows.Forms.TextBox();
            this.pnlCreateReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCreateReservation
            // 
            this.lblCreateReservation.AutoSize = true;
            this.lblCreateReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateReservation.Location = new System.Drawing.Point(173, 48);
            this.lblCreateReservation.Name = "lblCreateReservation";
            this.lblCreateReservation.Size = new System.Drawing.Size(535, 59);
            this.lblCreateReservation.TabIndex = 18;
            this.lblCreateReservation.Text = "Create a Reservation";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(39, 175);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(91, 22);
            this.lblStartDate.TabIndex = 19;
            this.lblStartDate.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(183, 175);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(241, 22);
            this.dtpStartDate.TabIndex = 20;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(488, 175);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(85, 22);
            this.lblEndDate.TabIndex = 21;
            this.lblEndDate.Text = "End Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(632, 175);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(241, 22);
            this.dtpEndDate.TabIndex = 22;
            // 
            // pnlCreateReservation
            // 
            this.pnlCreateReservation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCreateReservation.Controls.Add(this.lsvCreateReservation);
            this.pnlCreateReservation.Location = new System.Drawing.Point(43, 257);
            this.pnlCreateReservation.Name = "pnlCreateReservation";
            this.pnlCreateReservation.Size = new System.Drawing.Size(854, 444);
            this.pnlCreateReservation.TabIndex = 23;
            // 
            // lsvCreateReservation
            // 
            this.lsvCreateReservation.HideSelection = false;
            this.lsvCreateReservation.Location = new System.Drawing.Point(3, 3);
            this.lsvCreateReservation.Name = "lsvCreateReservation";
            this.lsvCreateReservation.Size = new System.Drawing.Size(846, 472);
            this.lsvCreateReservation.TabIndex = 0;
            this.lsvCreateReservation.UseCompatibleStateImageBehavior = false;
            // 
            // btnConfirmRegistration
            // 
            this.btnConfirmRegistration.Location = new System.Drawing.Point(720, 708);
            this.btnConfirmRegistration.Name = "btnConfirmRegistration";
            this.btnConfirmRegistration.Size = new System.Drawing.Size(177, 35);
            this.btnConfirmRegistration.TabIndex = 24;
            this.btnConfirmRegistration.Text = "Confirm Registration";
            this.btnConfirmRegistration.UseVisualStyleBackColor = true;
            // 
            // btnGoBackToAddGuest
            // 
            this.btnGoBackToAddGuest.Location = new System.Drawing.Point(43, 12);
            this.btnGoBackToAddGuest.Name = "btnGoBackToAddGuest";
            this.btnGoBackToAddGuest.Size = new System.Drawing.Size(75, 23);
            this.btnGoBackToAddGuest.TabIndex = 31;
            this.btnGoBackToAddGuest.Text = "Go Back";
            this.btnGoBackToAddGuest.UseVisualStyleBackColor = true;
            // 
            // txtGuestID
            // 
            this.txtGuestID.Location = new System.Drawing.Point(141, 220);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(293, 22);
            this.txtGuestID.TabIndex = 33;
            this.txtGuestID.Text = "As text change, the list below changes real time";
            // 
            // lblGuestID
            // 
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestID.Location = new System.Drawing.Point(43, 218);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(80, 22);
            this.lblGuestID.TabIndex = 32;
            this.lblGuestID.Text = "Guest ID";
            // 
            // lblHotelID
            // 
            this.lblHotelID.AutoSize = true;
            this.lblHotelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelID.Location = new System.Drawing.Point(43, 126);
            this.lblHotelID.Name = "lblHotelID";
            this.lblHotelID.Size = new System.Drawing.Size(74, 22);
            this.lblHotelID.TabIndex = 34;
            this.lblHotelID.Text = "Hotel ID";
            // 
            // txtHotelID
            // 
            this.txtHotelID.Location = new System.Drawing.Point(141, 128);
            this.txtHotelID.Name = "txtHotelID";
            this.txtHotelID.Size = new System.Drawing.Size(293, 22);
            this.txtHotelID.TabIndex = 35;
            this.txtHotelID.Text = "Realtime, also grey out if normal employee is doing it";
            // 
            // CreateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 755);
            this.Controls.Add(this.txtHotelID);
            this.Controls.Add(this.lblHotelID);
            this.Controls.Add(this.txtGuestID);
            this.Controls.Add(this.lblGuestID);
            this.Controls.Add(this.btnGoBackToAddGuest);
            this.Controls.Add(this.btnConfirmRegistration);
            this.Controls.Add(this.pnlCreateReservation);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblCreateReservation);
            this.Name = "CreateReservation";
            this.Text = "Create a New Reservation";
            this.Load += new System.EventHandler(this.CreateBooking_Load);
            this.pnlCreateReservation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateReservation;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Panel pnlCreateReservation;
        private System.Windows.Forms.ListView lsvCreateReservation;
        private System.Windows.Forms.Button btnConfirmRegistration;
        private System.Windows.Forms.Button btnGoBackToAddGuest;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.Label lblGuestID;
        private System.Windows.Forms.Label lblHotelID;
        private System.Windows.Forms.TextBox txtHotelID;
    }
}