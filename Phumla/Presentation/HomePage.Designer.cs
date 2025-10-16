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
            this.components = new System.ComponentModel.Container();
            this.poisonContextMenuStrip1 = new ReaLTaiizor.Controls.PoisonContextMenuStrip(this.components);
            this.gayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.btnSearchBooking = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnEditBooking = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new ReaLTaiizor.Controls.HeaderLabel();
            this.tbcHomePage = new ReaLTaiizor.Controls.MetroTabControl();
            this.poisonContextMenuStrip1.SuspendLayout();
            this.parrotGradientPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // poisonContextMenuStrip1
            // 
            this.poisonContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.poisonContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gayToolStripMenuItem,
            this.coreToolStripMenuItem1});
            this.poisonContextMenuStrip1.Name = "poisonContextMenuStrip1";
            this.poisonContextMenuStrip1.Size = new System.Drawing.Size(108, 52);
            this.poisonContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.poisonContextMenuStrip1_Opening);
            // 
            // gayToolStripMenuItem
            // 
            this.gayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slopToolStripMenuItem,
            this.coreToolStripMenuItem});
            this.gayToolStripMenuItem.Name = "gayToolStripMenuItem";
            this.gayToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.gayToolStripMenuItem.Text = "gay";
            // 
            // slopToolStripMenuItem
            // 
            this.slopToolStripMenuItem.Name = "slopToolStripMenuItem";
            this.slopToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.slopToolStripMenuItem.Text = "slop";
            // 
            // coreToolStripMenuItem
            // 
            this.coreToolStripMenuItem.Name = "coreToolStripMenuItem";
            this.coreToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.coreToolStripMenuItem.Text = "core";
            // 
            // coreToolStripMenuItem1
            // 
            this.coreToolStripMenuItem1.Name = "coreToolStripMenuItem1";
            this.coreToolStripMenuItem1.Size = new System.Drawing.Size(107, 24);
            this.coreToolStripMenuItem1.Text = "core";
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.Navy;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.Indigo;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.Controls.Add(this.tableLayoutPanel1);
            this.parrotGradientPanel1.Controls.Add(this.flowLayoutPanel1);
            this.parrotGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.parrotGradientPanel1.Name = "parrotGradientPanel1";
            this.parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel1.Size = new System.Drawing.Size(274, 594);
            this.parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.parrotGradientPanel1.TabIndex = 13;
            this.parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel1.TopLeft = System.Drawing.Color.DarkOrange;
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.Indigo;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnLogout, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAddBooking, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteBooking, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnEditBooking, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCreateReport, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSearchBooking, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 220);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(274, 374);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateReport.Location = new System.Drawing.Point(51, 259);
            this.btnCreateReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(171, 39);
            this.btnCreateReport.TabIndex = 1;
            this.btnCreateReport.Text = "Create Report";
            this.btnCreateReport.UseVisualStyleBackColor = true;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click_1);
            // 
            // btnSearchBooking
            // 
            this.btnSearchBooking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchBooking.AutoSize = true;
            this.btnSearchBooking.Location = new System.Drawing.Point(51, 197);
            this.btnSearchBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchBooking.Name = "btnSearchBooking";
            this.btnSearchBooking.Size = new System.Drawing.Size(171, 39);
            this.btnSearchBooking.TabIndex = 3;
            this.btnSearchBooking.Text = "Search Booking";
            this.btnSearchBooking.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.AutoSize = true;
            this.btnLogout.Location = new System.Drawing.Point(105, 329);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(63, 26);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddBooking.Location = new System.Drawing.Point(51, 11);
            this.btnAddBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(171, 39);
            this.btnAddBooking.TabIndex = 0;
            this.btnAddBooking.Text = "Add Booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteBooking.Location = new System.Drawing.Point(51, 135);
            this.btnDeleteBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(171, 39);
            this.btnDeleteBooking.TabIndex = 3;
            this.btnDeleteBooking.Text = "Delete Booking";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // btnEditBooking
            // 
            this.btnEditBooking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditBooking.Location = new System.Drawing.Point(51, 73);
            this.btnEditBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditBooking.Name = "btnEditBooking";
            this.btnEditBooking.Size = new System.Drawing.Size(171, 39);
            this.btnEditBooking.TabIndex = 4;
            this.btnEditBooking.Text = "Edit Booking";
            this.btnEditBooking.UseVisualStyleBackColor = true;
            this.btnEditBooking.Click += new System.EventHandler(this.btnEditBooking_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.lblWelcome);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(274, 97);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Phumla.Properties.Resources.PhumlaAppIcon;
            this.pictureBox1.Image = global::Phumla.Properties.Resources.PhumlaAppIcon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblWelcome.Location = new System.Drawing.Point(99, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(154, 72);
            this.lblWelcome.TabIndex = 10;
            this.lblWelcome.Text = "Welcome,\r\n[EMPID]";
            // 
            // tbcHomePage
            // 
            this.tbcHomePage.AnimateEasingType = ReaLTaiizor.Enum.Metro.EasingType.CubeOut;
            this.tbcHomePage.AnimateTime = 200;
            this.tbcHomePage.BackgroundColor = System.Drawing.Color.White;
            this.tbcHomePage.ControlsVisible = true;
            this.tbcHomePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcHomePage.IsDerivedStyle = true;
            this.tbcHomePage.ItemSize = new System.Drawing.Size(100, 38);
            this.tbcHomePage.Location = new System.Drawing.Point(274, 0);
            this.tbcHomePage.MCursor = System.Windows.Forms.Cursors.Hand;
            this.tbcHomePage.Name = "tbcHomePage";
            this.tbcHomePage.SelectedTextColor = System.Drawing.Color.White;
            this.tbcHomePage.Size = new System.Drawing.Size(962, 594);
            this.tbcHomePage.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcHomePage.Speed = 100;
            this.tbcHomePage.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.tbcHomePage.StyleManager = null;
            this.tbcHomePage.TabIndex = 14;
            this.tbcHomePage.ThemeAuthor = "Taiizor";
            this.tbcHomePage.ThemeName = "MetroLight";
            this.tbcHomePage.UnselectedTextColor = System.Drawing.Color.Gray;
            this.tbcHomePage.SelectedIndexChanged += new System.EventHandler(this.tbcHomePage_SelectedIndexChanged);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 594);
            this.Controls.Add(this.tbcHomePage);
            this.Controls.Add(this.parrotGradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomePage";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.poisonContextMenuStrip1.ResumeLayout(false);
            this.parrotGradientPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.PoisonContextMenuStrip poisonContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coreToolStripMenuItem1;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCreateReport;
        private System.Windows.Forms.Button btnSearchBooking;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button btnEditBooking;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.HeaderLabel lblWelcome;
        private ReaLTaiizor.Controls.MetroTabControl tbcHomePage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}