namespace Phumla.Presentation
{
    partial class AddBookingControl
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
            this.lblAddBooking = new ReaLTaiizor.Controls.BigLabel();
            this.flpGuest1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblGuest1 = new System.Windows.Forms.Label();
            this.txtGuest1 = new ReaLTaiizor.Controls.PoisonTextBox();
            this.lblGuest1Status = new System.Windows.Forms.Label();
            this.flpAddGuests = new System.Windows.Forms.FlowLayoutPanel();
            this.flpGuestButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddGuest = new ReaLTaiizor.Controls.AirButton();
            this.btnRemoveGuest = new ReaLTaiizor.Controls.AirButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHotelID = new System.Windows.Forms.Label();
            this.skyComboBox1 = new ReaLTaiizor.Controls.SkyComboBox();
            this.dtpStartDate = new ReaLTaiizor.Controls.PoisonDateTime();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new ReaLTaiizor.Controls.PoisonDateTime();
            this.txtSummary = new ReaLTaiizor.Controls.MetroRichTextBox();
            this.btnConfirmBooking = new ReaLTaiizor.Controls.AirButton();
            this.btnCancelBooking = new ReaLTaiizor.Controls.AirButton();
            this.flpGuest1.SuspendLayout();
            this.flpAddGuests.SuspendLayout();
            this.flpGuestButtons.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddBooking
            // 
            this.lblAddBooking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddBooking.AutoSize = true;
            this.lblAddBooking.BackColor = System.Drawing.Color.Transparent;
            this.lblAddBooking.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.lblAddBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblAddBooking.Location = new System.Drawing.Point(307, 12);
            this.lblAddBooking.Name = "lblAddBooking";
            this.lblAddBooking.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAddBooking.Size = new System.Drawing.Size(268, 57);
            this.lblAddBooking.TabIndex = 0;
            this.lblAddBooking.Text = "Add Booking";
            this.lblAddBooking.Click += new System.EventHandler(this.lblAddBooking_Click);
            // 
            // flpGuest1
            // 
            this.flpGuest1.Controls.Add(this.lblGuest1);
            this.flpGuest1.Controls.Add(this.txtGuest1);
            this.flpGuest1.Controls.Add(this.lblGuest1Status);
            this.flpGuest1.Location = new System.Drawing.Point(3, 3);
            this.flpGuest1.Name = "flpGuest1";
            this.flpGuest1.Size = new System.Drawing.Size(529, 40);
            this.flpGuest1.TabIndex = 1;
            // 
            // lblGuest1
            // 
            this.lblGuest1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGuest1.AutoSize = true;
            this.lblGuest1.Location = new System.Drawing.Point(3, 6);
            this.lblGuest1.Name = "lblGuest1";
            this.lblGuest1.Size = new System.Drawing.Size(61, 16);
            this.lblGuest1.TabIndex = 0;
            this.lblGuest1.Text = "Guest ID:";
            // 
            // txtGuest1
            // 
            // 
            // 
            // 
            this.txtGuest1.CustomButton.Image = null;
            this.txtGuest1.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtGuest1.CustomButton.Name = "";
            this.txtGuest1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGuest1.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.txtGuest1.CustomButton.TabIndex = 1;
            this.txtGuest1.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.txtGuest1.CustomButton.UseSelectable = true;
            this.txtGuest1.CustomButton.Visible = false;
            this.txtGuest1.Lines = new string[0];
            this.txtGuest1.Location = new System.Drawing.Point(70, 3);
            this.txtGuest1.MaxLength = 32767;
            this.txtGuest1.Name = "txtGuest1";
            this.txtGuest1.PasswordChar = '\0';
            this.txtGuest1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGuest1.SelectedText = "";
            this.txtGuest1.SelectionLength = 0;
            this.txtGuest1.SelectionStart = 0;
            this.txtGuest1.ShortcutsEnabled = true;
            this.txtGuest1.Size = new System.Drawing.Size(161, 23);
            this.txtGuest1.TabIndex = 1;
            this.txtGuest1.UseSelectable = true;
            this.txtGuest1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGuest1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtGuest1.TextChanged += new System.EventHandler(this.txtGuest_TextChanged);
            this.txtGuest1.Click += new System.EventHandler(this.txtGuest1_Click);
            // 
            // lblGuest1Status
            // 
            this.lblGuest1Status.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGuest1Status.AutoSize = true;
            this.lblGuest1Status.Location = new System.Drawing.Point(237, 6);
            this.lblGuest1Status.Name = "lblGuest1Status";
            this.lblGuest1Status.Size = new System.Drawing.Size(49, 16);
            this.lblGuest1Status.TabIndex = 2;
            this.lblGuest1Status.Text = "[Blank]";
            this.lblGuest1Status.Click += new System.EventHandler(this.lblGuestStatus_Clicked);
            // 
            // flpAddGuests
            // 
            this.flpAddGuests.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flpAddGuests.Controls.Add(this.flpGuest1);
            this.flpAddGuests.Controls.Add(this.flpGuestButtons);
            this.flpAddGuests.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAddGuests.Location = new System.Drawing.Point(3, 126);
            this.flpAddGuests.Name = "flpAddGuests";
            this.flpAddGuests.Size = new System.Drawing.Size(532, 309);
            this.flpAddGuests.TabIndex = 3;
            this.flpAddGuests.Paint += new System.Windows.Forms.PaintEventHandler(this.flpAddGuests_Paint);
            // 
            // flpGuestButtons
            // 
            this.flpGuestButtons.Controls.Add(this.btnAddGuest);
            this.flpGuestButtons.Controls.Add(this.btnRemoveGuest);
            this.flpGuestButtons.Location = new System.Drawing.Point(3, 49);
            this.flpGuestButtons.Name = "flpGuestButtons";
            this.flpGuestButtons.Size = new System.Drawing.Size(248, 35);
            this.flpGuestButtons.TabIndex = 2;
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGuest.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnAddGuest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddGuest.Image = null;
            this.btnAddGuest.Location = new System.Drawing.Point(3, 3);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.NoRounding = false;
            this.btnAddGuest.Size = new System.Drawing.Size(100, 23);
            this.btnAddGuest.TabIndex = 3;
            this.btnAddGuest.Text = "Add Guest";
            this.btnAddGuest.Transparent = false;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // btnRemoveGuest
            // 
            this.btnRemoveGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveGuest.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnRemoveGuest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoveGuest.Image = null;
            this.btnRemoveGuest.Location = new System.Drawing.Point(109, 3);
            this.btnRemoveGuest.Name = "btnRemoveGuest";
            this.btnRemoveGuest.NoRounding = false;
            this.btnRemoveGuest.Size = new System.Drawing.Size(122, 23);
            this.btnRemoveGuest.TabIndex = 4;
            this.btnRemoveGuest.Text = "Remove Guest";
            this.btnRemoveGuest.Transparent = false;
            this.btnRemoveGuest.Visible = false;
            this.btnRemoveGuest.Click += new System.EventHandler(this.btnRemoveGuest_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblHotelID);
            this.flowLayoutPanel1.Controls.Add(this.skyComboBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 87);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(532, 35);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // lblHotelID
            // 
            this.lblHotelID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHotelID.AutoSize = true;
            this.lblHotelID.Location = new System.Drawing.Point(3, 6);
            this.lblHotelID.Name = "lblHotelID";
            this.lblHotelID.Size = new System.Drawing.Size(64, 16);
            this.lblHotelID.TabIndex = 2;
            this.lblHotelID.Text = "Hotel ID:  ";
            // 
            // skyComboBox1
            // 
            this.skyComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.skyComboBox1.BGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.skyComboBox1.BGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.skyComboBox1.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.skyComboBox1.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.skyComboBox1.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.skyComboBox1.BorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.skyComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skyComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skyComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skyComboBox1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.skyComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyComboBox1.FormattingEnabled = true;
            this.skyComboBox1.ItemHeight = 16;
            this.skyComboBox1.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(176)))), ((int)(((byte)(214)))));
            this.skyComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.skyComboBox1.LineColorA = System.Drawing.Color.White;
            this.skyComboBox1.LineColorB = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.skyComboBox1.LineColorC = System.Drawing.Color.White;
            this.skyComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skyComboBox1.ListBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.skyComboBox1.ListDashType = System.Drawing.Drawing2D.DashStyle.Dot;
            this.skyComboBox1.ListForeColor = System.Drawing.Color.Black;
            this.skyComboBox1.ListSelectedBackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skyComboBox1.ListSelectedBackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skyComboBox1.Location = new System.Drawing.Point(73, 3);
            this.skyComboBox1.Name = "skyComboBox1";
            this.skyComboBox1.Size = new System.Drawing.Size(161, 22);
            this.skyComboBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.skyComboBox1.StartIndex = 0;
            this.skyComboBox1.TabIndex = 20;
            this.skyComboBox1.TriangleColorA = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(176)))), ((int)(((byte)(214)))));
            this.skyComboBox1.TriangleColorB = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyComboBox1.SelectedIndexChanged += new System.EventHandler(this.skyComboBox1_SelectedIndexChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            this.dtpStartDate.Location = new System.Drawing.Point(78, 3);
            this.dtpStartDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(263, 30);
            this.dtpStartDate.TabIndex = 10;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel2.Controls.Add(this.lblStartDate);
            this.flowLayoutPanel2.Controls.Add(this.dtpStartDate);
            this.flowLayoutPanel2.Controls.Add(this.lblEndDate);
            this.flowLayoutPanel2.Controls.Add(this.dtpEndDate);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(541, 87);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(355, 150);
            this.flowLayoutPanel2.TabIndex = 21;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(3, 10);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(69, 16);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(3, 46);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(69, 16);
            this.lblEndDate.TabIndex = 12;
            this.lblEndDate.Text = "End Date: ";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            this.dtpEndDate.Location = new System.Drawing.Point(78, 39);
            this.dtpEndDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(263, 30);
            this.dtpEndDate.TabIndex = 11;
            // 
            // txtSummary
            // 
            this.txtSummary.AutoWordSelection = false;
            this.txtSummary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtSummary.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSummary.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtSummary.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSummary.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtSummary.IsDerivedStyle = true;
            this.txtSummary.Lines = null;
            this.txtSummary.Location = new System.Drawing.Point(541, 252);
            this.txtSummary.MaxLength = 32767;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ReadOnly = false;
            this.txtSummary.Size = new System.Drawing.Size(355, 183);
            this.txtSummary.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.txtSummary.StyleManager = null;
            this.txtSummary.TabIndex = 22;
            this.txtSummary.Text = "metroRichTextBox1";
            this.txtSummary.ThemeAuthor = "Taiizor";
            this.txtSummary.ThemeName = "MetroLight";
            this.txtSummary.WordWrap = true;
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmBooking.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnConfirmBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConfirmBooking.Image = null;
            this.btnConfirmBooking.Location = new System.Drawing.Point(745, 441);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.NoRounding = false;
            this.btnConfirmBooking.Size = new System.Drawing.Size(151, 45);
            this.btnConfirmBooking.TabIndex = 23;
            this.btnConfirmBooking.Text = "Confirm Booking";
            this.btnConfirmBooking.Transparent = false;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelBooking.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnCancelBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelBooking.Image = null;
            this.btnCancelBooking.Location = new System.Drawing.Point(541, 441);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.NoRounding = false;
            this.btnCancelBooking.Size = new System.Drawing.Size(151, 45);
            this.btnCancelBooking.TabIndex = 24;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.Transparent = false;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // AddBookingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.btnConfirmBooking);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flpAddGuests);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.lblAddBooking);
            this.Name = "AddBookingControl";
            this.Size = new System.Drawing.Size(917, 514);
            this.Load += new System.EventHandler(this.AddBookingControl_Load);
            this.flpGuest1.ResumeLayout(false);
            this.flpGuest1.PerformLayout();
            this.flpAddGuests.ResumeLayout(false);
            this.flpGuestButtons.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel lblAddBooking;
        private System.Windows.Forms.FlowLayoutPanel flpGuest1;
        private System.Windows.Forms.Label lblGuest1;
        private ReaLTaiizor.Controls.PoisonTextBox txtGuest1;
        private System.Windows.Forms.FlowLayoutPanel flpAddGuests;
        private ReaLTaiizor.Controls.AirButton btnAddGuest;
        private System.Windows.Forms.FlowLayoutPanel flpGuestButtons;
        private ReaLTaiizor.Controls.AirButton btnRemoveGuest;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblHotelID;
        private ReaLTaiizor.Controls.SkyComboBox skyComboBox1;
        private System.Windows.Forms.Label lblGuest1Status;
        private ReaLTaiizor.Controls.PoisonDateTime dtpStartDate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private ReaLTaiizor.Controls.PoisonDateTime dtpEndDate;
        private ReaLTaiizor.Controls.MetroRichTextBox txtSummary;
        private ReaLTaiizor.Controls.AirButton btnConfirmBooking;
        private ReaLTaiizor.Controls.AirButton btnCancelBooking;
    }
}
