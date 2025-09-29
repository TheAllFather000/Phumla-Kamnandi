namespace Phumla.Presentation
{
    partial class HomePage
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
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRemoveGuest = new System.Windows.Forms.Button();
            this.btnEditBooking = new System.Windows.Forms.Button();
            this.lblHomePage = new System.Windows.Forms.Label();
            this.tpnlHomePage = new System.Windows.Forms.TableLayoutPanel();
            this.tpnlHomePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddBooking.Location = new System.Drawing.Point(221, 88);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(170, 40);
            this.btnAddBooking.TabIndex = 0;
            this.btnAddBooking.Text = "Add Booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateReport.Location = new System.Drawing.Point(221, 304);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(170, 40);
            this.btnCreateReport.TabIndex = 1;
            this.btnCreateReport.Text = "Create Report";
            this.btnCreateReport.UseVisualStyleBackColor = true;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(104, 40);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRemoveGuest
            // 
            this.btnRemoveGuest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveGuest.Location = new System.Drawing.Point(221, 232);
            this.btnRemoveGuest.Name = "btnRemoveGuest";
            this.btnRemoveGuest.Size = new System.Drawing.Size(170, 40);
            this.btnRemoveGuest.TabIndex = 3;
            this.btnRemoveGuest.Text = "Remove Booking";
            this.btnRemoveGuest.UseVisualStyleBackColor = true;
            this.btnRemoveGuest.Click += new System.EventHandler(this.btnRemoveGuest_Click);
            // 
            // btnEditBooking
            // 
            this.btnEditBooking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditBooking.Location = new System.Drawing.Point(221, 160);
            this.btnEditBooking.Name = "btnEditBooking";
            this.btnEditBooking.Size = new System.Drawing.Size(170, 40);
            this.btnEditBooking.TabIndex = 4;
            this.btnEditBooking.Text = "Edit Booking";
            this.btnEditBooking.UseVisualStyleBackColor = true;
            this.btnEditBooking.Click += new System.EventHandler(this.btnEditBooking_Click);
            // 
            // lblHomePage
            // 
            this.lblHomePage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHomePage.AutoSize = true;
            this.lblHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePage.Location = new System.Drawing.Point(81, 8);
            this.lblHomePage.Name = "lblHomePage";
            this.lblHomePage.Size = new System.Drawing.Size(451, 55);
            this.lblHomePage.TabIndex = 5;
            this.lblHomePage.Text = "Welcome, [FILL IN]";
            // 
            // tpnlHomePage
            // 
            this.tpnlHomePage.ColumnCount = 1;
            this.tpnlHomePage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlHomePage.Controls.Add(this.btnRemoveGuest, 0, 3);
            this.tpnlHomePage.Controls.Add(this.btnCreateReport, 0, 4);
            this.tpnlHomePage.Controls.Add(this.lblHomePage, 0, 0);
            this.tpnlHomePage.Controls.Add(this.btnAddBooking, 0, 1);
            this.tpnlHomePage.Controls.Add(this.btnEditBooking, 0, 2);
            this.tpnlHomePage.Location = new System.Drawing.Point(60, 99);
            this.tpnlHomePage.Name = "tpnlHomePage";
            this.tpnlHomePage.RowCount = 5;
            this.tpnlHomePage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tpnlHomePage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tpnlHomePage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tpnlHomePage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tpnlHomePage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tpnlHomePage.Size = new System.Drawing.Size(613, 360);
            this.tpnlHomePage.TabIndex = 6;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 515);
            this.Controls.Add(this.tpnlHomePage);
            this.Controls.Add(this.btnLogout);
            this.Name = "HomePage";
            this.Text = "Home Page: [HOTEL ID]";
            this.tpnlHomePage.ResumeLayout(false);
            this.tpnlHomePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Button btnCreateReport;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRemoveGuest;
        private System.Windows.Forms.Button btnEditBooking;
        private System.Windows.Forms.Label lblHomePage;
        private System.Windows.Forms.TableLayoutPanel tpnlHomePage;
    }
}