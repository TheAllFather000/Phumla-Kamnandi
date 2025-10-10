namespace Phumla.Presentation
{
    partial class AddBooking
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
            this.lblAddBooking = new System.Windows.Forms.Label();
            this.btnGoBackToAddGuest = new System.Windows.Forms.Button();
            this.pnlExisitingGuests = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.btnFinaliseGuestBooking = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtHotelID = new System.Windows.Forms.TextBox();
            this.lblHotelID = new System.Windows.Forms.Label();
            this.checkAvailability = new System.Windows.Forms.Button();
            this.metroContextMenuStrip1 = new ReaLTaiizor.Controls.MetroContextMenuStrip();
            this.addAGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new ReaLTaiizor.Controls.Button();
            this.pnlExisitingGuests.SuspendLayout();
            this.metroContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddBooking
            // 
            this.lblAddBooking.AutoSize = true;
            this.lblAddBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBooking.Location = new System.Drawing.Point(83, 38);
            this.lblAddBooking.Name = "lblAddBooking";
            this.lblAddBooking.Size = new System.Drawing.Size(376, 59);
            this.lblAddBooking.TabIndex = 18;
            this.lblAddBooking.Text = "Add a Booking";
            // 
            // btnGoBackToAddGuest
            // 
            this.btnGoBackToAddGuest.Location = new System.Drawing.Point(12, 12);
            this.btnGoBackToAddGuest.Name = "btnGoBackToAddGuest";
            this.btnGoBackToAddGuest.Size = new System.Drawing.Size(75, 23);
            this.btnGoBackToAddGuest.TabIndex = 31;
            this.btnGoBackToAddGuest.Text = "Go Back";
            this.btnGoBackToAddGuest.UseVisualStyleBackColor = true;
            this.btnGoBackToAddGuest.Click += new System.EventHandler(this.btnGoBackToAddGuest_Click);
            // 
            // pnlExisitingGuests
            // 
            this.pnlExisitingGuests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExisitingGuests.Controls.Add(this.listView1);
            this.pnlExisitingGuests.Location = new System.Drawing.Point(1170, 238);
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
            this.txtGuestID.Location = new System.Drawing.Point(1263, 167);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(251, 22);
            this.txtGuestID.TabIndex = 33;
            this.txtGuestID.Text = "As text change, the list below changes real time";
            // 
            // lblGuestID
            // 
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestID.Location = new System.Drawing.Point(1166, 165);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(80, 22);
            this.lblGuestID.TabIndex = 32;
            this.lblGuestID.Text = "Guest ID";
            // 
            // btnFinaliseGuestBooking
            // 
            this.btnFinaliseGuestBooking.Location = new System.Drawing.Point(1850, 739);
            this.btnFinaliseGuestBooking.Name = "btnFinaliseGuestBooking";
            this.btnFinaliseGuestBooking.Size = new System.Drawing.Size(147, 45);
            this.btnFinaliseGuestBooking.TabIndex = 35;
            this.btnFinaliseGuestBooking.Text = "Finalise Guest Booking";
            this.btnFinaliseGuestBooking.UseVisualStyleBackColor = true;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(1263, 201);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(251, 22);
            this.dtpStartDate.TabIndex = 36;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(1746, 201);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(251, 22);
            this.dtpEndDate.TabIndex = 37;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(1166, 201);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(91, 22);
            this.lblStartDate.TabIndex = 38;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(1655, 201);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(85, 22);
            this.lblEndDate.TabIndex = 39;
            this.lblEndDate.Text = "End Date";
            this.lblEndDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHotelID
            // 
            this.txtHotelID.Location = new System.Drawing.Point(1697, 165);
            this.txtHotelID.Name = "txtHotelID";
            this.txtHotelID.Size = new System.Drawing.Size(300, 22);
            this.txtHotelID.TabIndex = 41;
            this.txtHotelID.Text = "Greyed out if not manager";
            // 
            // lblHotelID
            // 
            this.lblHotelID.AutoSize = true;
            this.lblHotelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelID.Location = new System.Drawing.Point(1600, 165);
            this.lblHotelID.Name = "lblHotelID";
            this.lblHotelID.Size = new System.Drawing.Size(74, 22);
            this.lblHotelID.TabIndex = 40;
            this.lblHotelID.Text = "Hotel ID";
            // 
            // checkAvailability
            // 
            this.checkAvailability.Location = new System.Drawing.Point(1170, 739);
            this.checkAvailability.Name = "checkAvailability";
            this.checkAvailability.Size = new System.Drawing.Size(147, 45);
            this.checkAvailability.TabIndex = 42;
            this.checkAvailability.Text = "Check Room Availability";
            this.checkAvailability.UseVisualStyleBackColor = true;
            this.checkAvailability.Click += new System.EventHandler(this.checkAvailability_Click);
            // 
            // metroContextMenuStrip1
            // 
            this.metroContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenuStrip1.IsDerivedStyle = true;
            this.metroContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAGuestToolStripMenuItem});
            this.metroContextMenuStrip1.Name = "metroContextMenuStrip1";
            this.metroContextMenuStrip1.Size = new System.Drawing.Size(160, 28);
            this.metroContextMenuStrip1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroContextMenuStrip1.StyleManager = null;
            this.metroContextMenuStrip1.ThemeAuthor = "Taiizor";
            this.metroContextMenuStrip1.ThemeName = "MetroLight";
            // 
            // addAGuestToolStripMenuItem
            // 
            this.addAGuestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.existingToolStripMenuItem,
            this.newToolStripMenuItem});
            this.addAGuestToolStripMenuItem.Name = "addAGuestToolStripMenuItem";
            this.addAGuestToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.addAGuestToolStripMenuItem.Text = "Add a Guest";
            // 
            // existingToolStripMenuItem
            // 
            this.existingToolStripMenuItem.Name = "existingToolStripMenuItem";
            this.existingToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.existingToolStripMenuItem.Text = "Existing";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.ContextMenuStrip = this.metroContextMenuStrip1;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Image = null;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Location = new System.Drawing.Point(93, 201);
            this.button1.Name = "button1";
            this.button1.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 44;
            this.button1.Text = "button1";
            this.button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1921, 962);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkAvailability);
            this.Controls.Add(this.txtHotelID);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblHotelID);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnFinaliseGuestBooking);
            this.Controls.Add(this.pnlExisitingGuests);
            this.Controls.Add(this.txtGuestID);
            this.Controls.Add(this.lblGuestID);
            this.Controls.Add(this.btnGoBackToAddGuest);
            this.Controls.Add(this.lblAddBooking);
            this.Name = "AddBooking";
            this.Text = "Create a Guest Reservation";
            this.Load += new System.EventHandler(this.CreateReservation_Load);
            this.pnlExisitingGuests.ResumeLayout(false);
            this.metroContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddBooking;
        private System.Windows.Forms.Button btnGoBackToAddGuest;
        private System.Windows.Forms.Panel pnlExisitingGuests;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.Label lblGuestID;
        private System.Windows.Forms.Button btnFinaliseGuestBooking;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtHotelID;
        private System.Windows.Forms.Label lblHotelID;
        private System.Windows.Forms.Button checkAvailability;
        private ReaLTaiizor.Controls.MetroContextMenuStrip metroContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addAGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private ReaLTaiizor.Controls.Button button1;
    }
}