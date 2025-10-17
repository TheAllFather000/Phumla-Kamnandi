namespace Phumla.Presentation
{
    partial class SearchBookingControl
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
            this.lsvBookings = new ReaLTaiizor.Controls.MaterialListView();
            this.lblSearchBooking = new ReaLTaiizor.Controls.BigLabel();
            this.txtSummary = new ReaLTaiizor.Controls.MetroRichTextBox();
            this.SuspendLayout();
            // 
            // lsvBookings
            // 
            this.lsvBookings.AutoSizeTable = false;
            this.lsvBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lsvBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvBookings.Depth = 0;
            this.lsvBookings.FullRowSelect = true;
            this.lsvBookings.HideSelection = false;
            this.lsvBookings.Location = new System.Drawing.Point(3, 98);
            this.lsvBookings.MinimumSize = new System.Drawing.Size(200, 100);
            this.lsvBookings.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lsvBookings.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.lsvBookings.Name = "lsvBookings";
            this.lsvBookings.OwnerDraw = true;
            this.lsvBookings.Size = new System.Drawing.Size(907, 507);
            this.lsvBookings.TabIndex = 9;
            this.lsvBookings.UseCompatibleStateImageBehavior = false;
            this.lsvBookings.View = System.Windows.Forms.View.Details;
            this.lsvBookings.SelectedIndexChanged += new System.EventHandler(this.lsvBookings_SelectedIndexChanged);
            // 
            // lblSearchBooking
            // 
            this.lblSearchBooking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSearchBooking.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchBooking.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.lblSearchBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblSearchBooking.Location = new System.Drawing.Point(417, 0);
            this.lblSearchBooking.Name = "lblSearchBooking";
            this.lblSearchBooking.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSearchBooking.Size = new System.Drawing.Size(332, 57);
            this.lblSearchBooking.TabIndex = 8;
            this.lblSearchBooking.Text = "Search Booking";
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
            this.txtSummary.Location = new System.Drawing.Point(932, 380);
            this.txtSummary.MaxLength = 32767;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ReadOnly = false;
            this.txtSummary.Size = new System.Drawing.Size(317, 225);
            this.txtSummary.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.txtSummary.StyleManager = null;
            this.txtSummary.TabIndex = 10;
            this.txtSummary.Text = "Summary:";
            this.txtSummary.ThemeAuthor = "Taiizor";
            this.txtSummary.ThemeName = "MetroLight";
            this.txtSummary.WordWrap = true;
            // 
            // SearchBookingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.lsvBookings);
            this.Controls.Add(this.lblSearchBooking);
            this.Name = "SearchBookingControl";
            this.Size = new System.Drawing.Size(1322, 624);
            this.Load += new System.EventHandler(this.SearchBooking_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialListView lsvBookings;
        private ReaLTaiizor.Controls.BigLabel lblSearchBooking;
        private ReaLTaiizor.Controls.MetroRichTextBox txtSummary;
    }
}
