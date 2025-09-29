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
            this.lblAddGuest = new System.Windows.Forms.Label();
            this.btnGoBackToAddGuest = new System.Windows.Forms.Button();
            this.pnlExisitingGuests = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.btnFinaliseGuestReservation = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtHotelID = new System.Windows.Forms.TextBox();
            this.lblHotelID = new System.Windows.Forms.Label();
            this.pnlExisitingGuests.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddGuest
            // 
            this.lblAddGuest.AutoSize = true;
            this.lblAddGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGuest.Location = new System.Drawing.Point(83, 38);
            this.lblAddGuest.Name = "lblAddGuest";
            this.lblAddGuest.Size = new System.Drawing.Size(535, 59);
            this.lblAddGuest.TabIndex = 18;
            this.lblAddGuest.Text = "Create a Reservation";
            // 
            // btnGoBackToAddGuest
            // 
            this.btnGoBackToAddGuest.Location = new System.Drawing.Point(12, 12);
            this.btnGoBackToAddGuest.Name = "btnGoBackToAddGuest";
            this.btnGoBackToAddGuest.Size = new System.Drawing.Size(75, 23);
            this.btnGoBackToAddGuest.TabIndex = 31;
            this.btnGoBackToAddGuest.Text = "Go Back";
            this.btnGoBackToAddGuest.UseVisualStyleBackColor = true;
            // 
            // pnlExisitingGuests
            // 
            this.pnlExisitingGuests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExisitingGuests.Controls.Add(this.listView1);
            this.pnlExisitingGuests.Location = new System.Drawing.Point(89, 171);
            this.pnlExisitingGuests.Name = "pnlExisitingGuests";
            this.pnlExisitingGuests.Size = new System.Drawing.Size(827, 495);
            this.pnlExisitingGuests.TabIndex = 34;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(816, 487);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txtGuestID
            // 
            this.txtGuestID.Location = new System.Drawing.Point(182, 100);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(251, 22);
            this.txtGuestID.TabIndex = 33;
            this.txtGuestID.Text = "As text change, the list below changes real time";
            // 
            // lblGuestID
            // 
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestID.Location = new System.Drawing.Point(85, 98);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(80, 22);
            this.lblGuestID.TabIndex = 32;
            this.lblGuestID.Text = "Guest ID";
            // 
            // btnFinaliseGuestReservation
            // 
            this.btnFinaliseGuestReservation.Location = new System.Drawing.Point(769, 672);
            this.btnFinaliseGuestReservation.Name = "btnFinaliseGuestReservation";
            this.btnFinaliseGuestReservation.Size = new System.Drawing.Size(147, 45);
            this.btnFinaliseGuestReservation.TabIndex = 35;
            this.btnFinaliseGuestReservation.Text = "Finalise Guest Reservation";
            this.btnFinaliseGuestReservation.UseVisualStyleBackColor = true;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(182, 134);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(251, 22);
            this.dtpStartDate.TabIndex = 36;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(665, 134);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(251, 22);
            this.dtpEndDate.TabIndex = 37;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(85, 134);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(91, 22);
            this.lblStartDate.TabIndex = 38;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(574, 134);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(85, 22);
            this.lblEndDate.TabIndex = 39;
            this.lblEndDate.Text = "End Date";
            this.lblEndDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHotelID
            // 
            this.txtHotelID.Location = new System.Drawing.Point(616, 98);
            this.txtHotelID.Name = "txtHotelID";
            this.txtHotelID.Size = new System.Drawing.Size(300, 22);
            this.txtHotelID.TabIndex = 41;
            this.txtHotelID.Text = "As text change, the list below changes real time";
            // 
            // lblHotelID
            // 
            this.lblHotelID.AutoSize = true;
            this.lblHotelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelID.Location = new System.Drawing.Point(519, 98);
            this.lblHotelID.Name = "lblHotelID";
            this.lblHotelID.Size = new System.Drawing.Size(74, 22);
            this.lblHotelID.TabIndex = 40;
            this.lblHotelID.Text = "Hotel ID";
            // 
            // CreateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 720);
            this.Controls.Add(this.txtHotelID);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblHotelID);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnFinaliseGuestReservation);
            this.Controls.Add(this.pnlExisitingGuests);
            this.Controls.Add(this.txtGuestID);
            this.Controls.Add(this.lblGuestID);
            this.Controls.Add(this.btnGoBackToAddGuest);
            this.Controls.Add(this.lblAddGuest);
            this.Name = "CreateReservation";
            this.Text = "Create a Guest Reservation";
            this.Load += new System.EventHandler(this.CreateReservation_Load);
            this.pnlExisitingGuests.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddGuest;
        private System.Windows.Forms.Button btnGoBackToAddGuest;
        private System.Windows.Forms.Panel pnlExisitingGuests;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.Label lblGuestID;
        private System.Windows.Forms.Button btnFinaliseGuestReservation;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtHotelID;
        private System.Windows.Forms.Label lblHotelID;
    }
}