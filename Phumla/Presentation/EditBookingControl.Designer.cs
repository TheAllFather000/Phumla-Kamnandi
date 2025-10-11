namespace Phumla.Presentation
{
    partial class EditBookingControl
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
            this.lblEditBooking = new ReaLTaiizor.Controls.BigLabel();
            this.lsvBookings = new ReaLTaiizor.Controls.MaterialListView();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.lblHotelID = new System.Windows.Forms.Label();
            this.lblCheckedIn = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblDepositStatus = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.txtBookingID = new ReaLTaiizor.Controls.PoisonTextBox();
            this.txtHotelID = new ReaLTaiizor.Controls.PoisonTextBox();
            this.txtDepositStatus = new ReaLTaiizor.Controls.PoisonTextBox();
            this.txtBill = new ReaLTaiizor.Controls.PoisonTextBox();
            this.txtRoomID = new ReaLTaiizor.Controls.PoisonTextBox();
            this.dtpEndDate = new ReaLTaiizor.Controls.PoisonDateTime();
            this.dtpStartDate = new ReaLTaiizor.Controls.PoisonDateTime();
            this.tlpBookingDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblGuestList = new System.Windows.Forms.Label();
            this.txtGuestList = new ReaLTaiizor.Controls.MetroRichTextBox();
            this.cbxCheckedIn = new ReaLTaiizor.Controls.PoisonCheckBox();
            this.btnConfirmChanges = new ReaLTaiizor.Controls.AirButton();
            this.btnCancelChanges = new ReaLTaiizor.Controls.AirButton();
            this.tlpBookingDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEditBooking
            // 
            this.lblEditBooking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditBooking.BackColor = System.Drawing.Color.Transparent;
            this.lblEditBooking.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.lblEditBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblEditBooking.Location = new System.Drawing.Point(726, 0);
            this.lblEditBooking.Name = "lblEditBooking";
            this.lblEditBooking.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEditBooking.Size = new System.Drawing.Size(261, 57);
            this.lblEditBooking.TabIndex = 1;
            this.lblEditBooking.Text = "Edit Booking";
            // 
            // lsvBookings
            // 
            this.lsvBookings.AutoSizeTable = false;
            this.lsvBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lsvBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvBookings.Depth = 0;
            this.lsvBookings.FullRowSelect = true;
            this.lsvBookings.HideSelection = false;
            this.lsvBookings.Location = new System.Drawing.Point(505, 74);
            this.lsvBookings.MinimumSize = new System.Drawing.Size(200, 100);
            this.lsvBookings.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lsvBookings.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.lsvBookings.Name = "lsvBookings";
            this.lsvBookings.OwnerDraw = true;
            this.lsvBookings.Size = new System.Drawing.Size(1170, 492);
            this.lsvBookings.TabIndex = 2;
            this.lsvBookings.UseCompatibleStateImageBehavior = false;
            this.lsvBookings.View = System.Windows.Forms.View.Details;
            this.lsvBookings.SelectedIndexChanged += new System.EventHandler(this.lsvBookings_SelectedIndexChanged);
            // 
            // lblBookingID
            // 
            this.lblBookingID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Enabled = false;
            this.lblBookingID.Location = new System.Drawing.Point(6, 16);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(76, 16);
            this.lblBookingID.TabIndex = 0;
            this.lblBookingID.Text = "Booking ID:";
            // 
            // lblHotelID
            // 
            this.lblHotelID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHotelID.AutoSize = true;
            this.lblHotelID.Location = new System.Drawing.Point(6, 62);
            this.lblHotelID.Name = "lblHotelID";
            this.lblHotelID.Size = new System.Drawing.Size(55, 16);
            this.lblHotelID.TabIndex = 1;
            this.lblHotelID.Text = "Hotel ID";
            // 
            // lblCheckedIn
            // 
            this.lblCheckedIn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCheckedIn.AutoSize = true;
            this.lblCheckedIn.Location = new System.Drawing.Point(6, 246);
            this.lblCheckedIn.Name = "lblCheckedIn";
            this.lblCheckedIn.Size = new System.Drawing.Size(118, 16);
            this.lblCheckedIn.TabIndex = 2;
            this.lblCheckedIn.Text = "Checked-In Status:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(6, 154);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(69, 16);
            this.lblStartDate.TabIndex = 3;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(6, 200);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(66, 16);
            this.lblEndDate.TabIndex = 4;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(6, 108);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(98, 16);
            this.lblRoomNumber.TabIndex = 5;
            this.lblRoomNumber.Text = "Room Number:";
            // 
            // lblDepositStatus
            // 
            this.lblDepositStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDepositStatus.AutoSize = true;
            this.lblDepositStatus.Location = new System.Drawing.Point(6, 292);
            this.lblDepositStatus.Name = "lblDepositStatus";
            this.lblDepositStatus.Size = new System.Drawing.Size(97, 16);
            this.lblDepositStatus.TabIndex = 6;
            this.lblDepositStatus.Text = "Deposit Status:";
            // 
            // lblBill
            // 
            this.lblBill.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBill.AutoSize = true;
            this.lblBill.Location = new System.Drawing.Point(6, 338);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(28, 16);
            this.lblBill.TabIndex = 7;
            this.lblBill.Text = "Bill:";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.txtBookingID.CustomButton.Image = null;
            this.txtBookingID.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.txtBookingID.CustomButton.Name = "";
            this.txtBookingID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBookingID.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.txtBookingID.CustomButton.TabIndex = 1;
            this.txtBookingID.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.txtBookingID.CustomButton.UseSelectable = true;
            this.txtBookingID.CustomButton.Visible = false;
            this.txtBookingID.Lines = new string[0];
            this.txtBookingID.Location = new System.Drawing.Point(171, 13);
            this.txtBookingID.MaxLength = 32767;
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.PasswordChar = '\0';
            this.txtBookingID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookingID.SelectedText = "";
            this.txtBookingID.SelectionLength = 0;
            this.txtBookingID.SelectionStart = 0;
            this.txtBookingID.ShortcutsEnabled = true;
            this.txtBookingID.Size = new System.Drawing.Size(219, 23);
            this.txtBookingID.TabIndex = 4;
            this.txtBookingID.UseSelectable = true;
            this.txtBookingID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookingID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBookingID.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtBookingID.Click += new System.EventHandler(this.txtBookingID_Click);
            // 
            // txtHotelID
            // 
            this.txtHotelID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.txtHotelID.CustomButton.Image = null;
            this.txtHotelID.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtHotelID.CustomButton.Name = "";
            this.txtHotelID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHotelID.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.txtHotelID.CustomButton.TabIndex = 1;
            this.txtHotelID.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.txtHotelID.CustomButton.UseSelectable = true;
            this.txtHotelID.CustomButton.Visible = false;
            this.txtHotelID.Lines = new string[0];
            this.txtHotelID.Location = new System.Drawing.Point(171, 59);
            this.txtHotelID.MaxLength = 32767;
            this.txtHotelID.Name = "txtHotelID";
            this.txtHotelID.PasswordChar = '\0';
            this.txtHotelID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHotelID.SelectedText = "";
            this.txtHotelID.SelectionLength = 0;
            this.txtHotelID.SelectionStart = 0;
            this.txtHotelID.ShortcutsEnabled = true;
            this.txtHotelID.Size = new System.Drawing.Size(222, 23);
            this.txtHotelID.TabIndex = 8;
            this.txtHotelID.UseSelectable = true;
            this.txtHotelID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHotelID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHotelID.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtDepositStatus
            // 
            this.txtDepositStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.txtDepositStatus.CustomButton.Image = null;
            this.txtDepositStatus.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtDepositStatus.CustomButton.Name = "";
            this.txtDepositStatus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDepositStatus.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.txtDepositStatus.CustomButton.TabIndex = 1;
            this.txtDepositStatus.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.txtDepositStatus.CustomButton.UseSelectable = true;
            this.txtDepositStatus.CustomButton.Visible = false;
            this.txtDepositStatus.Lines = new string[0];
            this.txtDepositStatus.Location = new System.Drawing.Point(171, 289);
            this.txtDepositStatus.MaxLength = 32767;
            this.txtDepositStatus.Name = "txtDepositStatus";
            this.txtDepositStatus.PasswordChar = '\0';
            this.txtDepositStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDepositStatus.SelectedText = "";
            this.txtDepositStatus.SelectionLength = 0;
            this.txtDepositStatus.SelectionStart = 0;
            this.txtDepositStatus.ShortcutsEnabled = true;
            this.txtDepositStatus.Size = new System.Drawing.Size(161, 23);
            this.txtDepositStatus.TabIndex = 9;
            this.txtDepositStatus.UseSelectable = true;
            this.txtDepositStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDepositStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDepositStatus.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtBill
            // 
            this.txtBill.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.txtBill.CustomButton.Image = null;
            this.txtBill.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtBill.CustomButton.Name = "";
            this.txtBill.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBill.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.txtBill.CustomButton.TabIndex = 1;
            this.txtBill.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.txtBill.CustomButton.UseSelectable = true;
            this.txtBill.CustomButton.Visible = false;
            this.txtBill.Lines = new string[0];
            this.txtBill.Location = new System.Drawing.Point(171, 335);
            this.txtBill.MaxLength = 32767;
            this.txtBill.Name = "txtBill";
            this.txtBill.PasswordChar = '\0';
            this.txtBill.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBill.SelectedText = "";
            this.txtBill.SelectionLength = 0;
            this.txtBill.SelectionStart = 0;
            this.txtBill.ShortcutsEnabled = true;
            this.txtBill.Size = new System.Drawing.Size(161, 23);
            this.txtBill.TabIndex = 10;
            this.txtBill.UseSelectable = true;
            this.txtBill.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBill.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBill.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtRoomID
            // 
            this.txtRoomID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.txtRoomID.CustomButton.Image = null;
            this.txtRoomID.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtRoomID.CustomButton.Name = "";
            this.txtRoomID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRoomID.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.txtRoomID.CustomButton.TabIndex = 1;
            this.txtRoomID.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.txtRoomID.CustomButton.UseSelectable = true;
            this.txtRoomID.CustomButton.Visible = false;
            this.txtRoomID.Lines = new string[0];
            this.txtRoomID.Location = new System.Drawing.Point(171, 105);
            this.txtRoomID.MaxLength = 32767;
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.PasswordChar = '\0';
            this.txtRoomID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRoomID.SelectedText = "";
            this.txtRoomID.SelectionLength = 0;
            this.txtRoomID.SelectionStart = 0;
            this.txtRoomID.ShortcutsEnabled = true;
            this.txtRoomID.Size = new System.Drawing.Size(161, 23);
            this.txtRoomID.TabIndex = 11;
            this.txtRoomID.UseSelectable = true;
            this.txtRoomID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRoomID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRoomID.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpEndDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            this.dtpEndDate.Location = new System.Drawing.Point(171, 193);
            this.dtpEndDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(272, 30);
            this.dtpEndDate.TabIndex = 12;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpStartDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            this.dtpStartDate.Location = new System.Drawing.Point(171, 147);
            this.dtpStartDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(272, 30);
            this.dtpStartDate.TabIndex = 4;
            // 
            // tlpBookingDetails
            // 
            this.tlpBookingDetails.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tlpBookingDetails.ColumnCount = 2;
            this.tlpBookingDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.44068F));
            this.tlpBookingDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.55932F));
            this.tlpBookingDetails.Controls.Add(this.lblGuestList, 0, 8);
            this.tlpBookingDetails.Controls.Add(this.txtGuestList, 1, 8);
            this.tlpBookingDetails.Controls.Add(this.cbxCheckedIn, 1, 5);
            this.tlpBookingDetails.Controls.Add(this.lblBookingID, 0, 0);
            this.tlpBookingDetails.Controls.Add(this.txtBookingID, 1, 0);
            this.tlpBookingDetails.Controls.Add(this.lblBill, 0, 7);
            this.tlpBookingDetails.Controls.Add(this.txtDepositStatus, 1, 6);
            this.tlpBookingDetails.Controls.Add(this.lblHotelID, 0, 1);
            this.tlpBookingDetails.Controls.Add(this.lblRoomNumber, 0, 2);
            this.tlpBookingDetails.Controls.Add(this.txtBill, 1, 7);
            this.tlpBookingDetails.Controls.Add(this.lblDepositStatus, 0, 6);
            this.tlpBookingDetails.Controls.Add(this.txtHotelID, 1, 1);
            this.tlpBookingDetails.Controls.Add(this.lblStartDate, 0, 3);
            this.tlpBookingDetails.Controls.Add(this.txtRoomID, 1, 2);
            this.tlpBookingDetails.Controls.Add(this.dtpEndDate, 1, 4);
            this.tlpBookingDetails.Controls.Add(this.lblEndDate, 0, 4);
            this.tlpBookingDetails.Controls.Add(this.dtpStartDate, 1, 3);
            this.tlpBookingDetails.Controls.Add(this.lblCheckedIn, 0, 5);
            this.tlpBookingDetails.Location = new System.Drawing.Point(21, 74);
            this.tlpBookingDetails.Name = "tlpBookingDetails";
            this.tlpBookingDetails.RowCount = 9;
            this.tlpBookingDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBookingDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBookingDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBookingDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBookingDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBookingDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBookingDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBookingDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBookingDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBookingDetails.Size = new System.Drawing.Size(454, 492);
            this.tlpBookingDetails.TabIndex = 13;
            // 
            // lblGuestList
            // 
            this.lblGuestList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGuestList.AutoSize = true;
            this.lblGuestList.Location = new System.Drawing.Point(6, 422);
            this.lblGuestList.Name = "lblGuestList";
            this.lblGuestList.Size = new System.Drawing.Size(52, 16);
            this.lblGuestList.TabIndex = 15;
            this.lblGuestList.Text = "Guests:";
            // 
            // txtGuestList
            // 
            this.txtGuestList.AutoWordSelection = false;
            this.txtGuestList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtGuestList.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtGuestList.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtGuestList.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtGuestList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGuestList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtGuestList.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtGuestList.IsDerivedStyle = true;
            this.txtGuestList.Lines = null;
            this.txtGuestList.Location = new System.Drawing.Point(171, 374);
            this.txtGuestList.MaxLength = 32767;
            this.txtGuestList.Name = "txtGuestList";
            this.txtGuestList.ReadOnly = false;
            this.txtGuestList.Size = new System.Drawing.Size(277, 112);
            this.txtGuestList.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.txtGuestList.StyleManager = null;
            this.txtGuestList.TabIndex = 14;
            this.txtGuestList.ThemeAuthor = "Taiizor";
            this.txtGuestList.ThemeName = "MetroLight";
            this.txtGuestList.WordWrap = true;
            // 
            // cbxCheckedIn
            // 
            this.cbxCheckedIn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxCheckedIn.AutoSize = true;
            this.cbxCheckedIn.Location = new System.Drawing.Point(171, 246);
            this.cbxCheckedIn.Name = "cbxCheckedIn";
            this.cbxCheckedIn.Size = new System.Drawing.Size(94, 17);
            this.cbxCheckedIn.TabIndex = 14;
            this.cbxCheckedIn.Text = "Checked-In?";
            this.cbxCheckedIn.UseSelectable = true;
            this.cbxCheckedIn.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // btnConfirmChanges
            // 
            this.btnConfirmChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmChanges.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnConfirmChanges.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConfirmChanges.Image = null;
            this.btnConfirmChanges.Location = new System.Drawing.Point(315, 572);
            this.btnConfirmChanges.Name = "btnConfirmChanges";
            this.btnConfirmChanges.NoRounding = false;
            this.btnConfirmChanges.Size = new System.Drawing.Size(160, 45);
            this.btnConfirmChanges.TabIndex = 14;
            this.btnConfirmChanges.Text = "Confirm Changes";
            this.btnConfirmChanges.Transparent = false;
            this.btnConfirmChanges.Click += new System.EventHandler(this.btnConfirmChanges_Click);
            // 
            // btnCancelChanges
            // 
            this.btnCancelChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelChanges.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnCancelChanges.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelChanges.Image = null;
            this.btnCancelChanges.Location = new System.Drawing.Point(21, 572);
            this.btnCancelChanges.Name = "btnCancelChanges";
            this.btnCancelChanges.NoRounding = false;
            this.btnCancelChanges.Size = new System.Drawing.Size(160, 45);
            this.btnCancelChanges.TabIndex = 15;
            this.btnCancelChanges.Text = "Cancel Changes";
            this.btnCancelChanges.Transparent = false;
            this.btnCancelChanges.Click += new System.EventHandler(this.btnCancelChanges_Click);
            // 
            // EditBookingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelChanges);
            this.Controls.Add(this.btnConfirmChanges);
            this.Controls.Add(this.tlpBookingDetails);
            this.Controls.Add(this.lsvBookings);
            this.Controls.Add(this.lblEditBooking);
            this.Name = "EditBookingControl";
            this.Size = new System.Drawing.Size(1695, 695);
            this.Load += new System.EventHandler(this.EditBookingControl_Load);
            this.tlpBookingDetails.ResumeLayout(false);
            this.tlpBookingDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel lblEditBooking;
        private ReaLTaiizor.Controls.MaterialListView lsvBookings;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label lblHotelID;
        private System.Windows.Forms.Label lblCheckedIn;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblDepositStatus;
        private System.Windows.Forms.Label lblBill;
        private ReaLTaiizor.Controls.PoisonTextBox txtBookingID;
        private ReaLTaiizor.Controls.PoisonTextBox txtHotelID;
        private ReaLTaiizor.Controls.PoisonTextBox txtDepositStatus;
        private ReaLTaiizor.Controls.PoisonTextBox txtBill;
        private ReaLTaiizor.Controls.PoisonTextBox txtRoomID;
        private ReaLTaiizor.Controls.PoisonDateTime dtpEndDate;
        private ReaLTaiizor.Controls.PoisonDateTime dtpStartDate;
        private System.Windows.Forms.TableLayoutPanel tlpBookingDetails;
        private ReaLTaiizor.Controls.PoisonCheckBox cbxCheckedIn;
        private ReaLTaiizor.Controls.MetroRichTextBox txtGuestList;
        private System.Windows.Forms.Label lblGuestList;
        private ReaLTaiizor.Controls.AirButton btnConfirmChanges;
        private ReaLTaiizor.Controls.AirButton btnCancelChanges;
    }
}
