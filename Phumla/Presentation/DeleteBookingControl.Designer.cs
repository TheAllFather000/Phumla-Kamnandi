namespace Phumla.Presentation
{
    partial class DeleteBookingControl
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
            this.lblDeleteBooking = new ReaLTaiizor.Controls.BigLabel();
            this.lsvBookings = new ReaLTaiizor.Controls.MaterialListView();
            this.btnDeleteBooking = new ReaLTaiizor.Controls.AirButton();
            this.poisonDateTime1 = new ReaLTaiizor.Controls.PoisonDateTime();
            this.poisonDateTime2 = new ReaLTaiizor.Controls.PoisonDateTime();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeleteBooking
            // 
            this.lblDeleteBooking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDeleteBooking.BackColor = System.Drawing.Color.Transparent;
            this.lblDeleteBooking.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.lblDeleteBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblDeleteBooking.Location = new System.Drawing.Point(462, 0);
            this.lblDeleteBooking.Name = "lblDeleteBooking";
            this.lblDeleteBooking.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDeleteBooking.Size = new System.Drawing.Size(310, 57);
            this.lblDeleteBooking.TabIndex = 2;
            this.lblDeleteBooking.Text = "Delete Booking";
            // 
            // lsvBookings
            // 
            this.lsvBookings.AutoSizeTable = false;
            this.lsvBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lsvBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvBookings.Depth = 0;
            this.lsvBookings.FullRowSelect = true;
            this.lsvBookings.HideSelection = false;
            this.lsvBookings.Location = new System.Drawing.Point(373, 74);
            this.lsvBookings.MinimumSize = new System.Drawing.Size(200, 100);
            this.lsvBookings.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lsvBookings.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.lsvBookings.Name = "lsvBookings";
            this.lsvBookings.OwnerDraw = true;
            this.lsvBookings.Size = new System.Drawing.Size(907, 507);
            this.lsvBookings.TabIndex = 3;
            this.lsvBookings.UseCompatibleStateImageBehavior = false;
            this.lsvBookings.View = System.Windows.Forms.View.Details;
            this.lsvBookings.SelectedIndexChanged += new System.EventHandler(this.lsvBookings_SelectedIndexChanged);
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBooking.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnDeleteBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteBooking.Image = null;
            this.btnDeleteBooking.Location = new System.Drawing.Point(204, 518);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.NoRounding = false;
            this.btnDeleteBooking.Size = new System.Drawing.Size(163, 63);
            this.btnDeleteBooking.TabIndex = 4;
            this.btnDeleteBooking.Text = "Delete Booking";
            this.btnDeleteBooking.Transparent = false;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // poisonDateTime1
            // 
            this.poisonDateTime1.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            this.poisonDateTime1.Location = new System.Drawing.Point(117, 6);
            this.poisonDateTime1.MinimumSize = new System.Drawing.Size(0, 30);
            this.poisonDateTime1.Name = "poisonDateTime1";
            this.poisonDateTime1.Size = new System.Drawing.Size(230, 30);
            this.poisonDateTime1.TabIndex = 5;
            // 
            // poisonDateTime2
            // 
            this.poisonDateTime2.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            this.poisonDateTime2.Location = new System.Drawing.Point(117, 153);
            this.poisonDateTime2.MinimumSize = new System.Drawing.Size(0, 30);
            this.poisonDateTime2.Name = "poisonDateTime2";
            this.poisonDateTime2.Size = new System.Drawing.Size(230, 30);
            this.poisonDateTime2.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.44476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.55524F));
            this.tableLayoutPanel1.Controls.Add(this.poisonDateTime1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.poisonDateTime2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblStartDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEndDate, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(353, 297);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(6, 3);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(69, 16);
            this.lblStartDate.TabIndex = 7;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(6, 150);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(66, 16);
            this.lblEndDate.TabIndex = 8;
            this.lblEndDate.Text = "End Date:";
            // 
            // DeleteBookingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnDeleteBooking);
            this.Controls.Add(this.lsvBookings);
            this.Controls.Add(this.lblDeleteBooking);
            this.Name = "DeleteBookingControl";
            this.Size = new System.Drawing.Size(1295, 653);
            this.Load += new System.EventHandler(this.DeleteBookingControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel lblDeleteBooking;
        private ReaLTaiizor.Controls.MaterialListView lsvBookings;
        private ReaLTaiizor.Controls.AirButton btnDeleteBooking;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime1;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
    }
}
