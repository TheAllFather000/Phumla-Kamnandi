namespace Phumla.Presentation
{
    partial class CreateReport
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
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.btnGoBackToAddGuest = new System.Windows.Forms.Button();
            this.lblCreateReport = new System.Windows.Forms.Label();
            this.txtHotelID = new System.Windows.Forms.TextBox();
            this.lblHotelID = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Location = new System.Drawing.Point(307, 503);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(147, 45);
            this.btnCreateReport.TabIndex = 29;
            this.btnCreateReport.Text = "Create Report";
            this.btnCreateReport.UseVisualStyleBackColor = true;
            // 
            // btnGoBackToAddGuest
            // 
            this.btnGoBackToAddGuest.Location = new System.Drawing.Point(27, 30);
            this.btnGoBackToAddGuest.Name = "btnGoBackToAddGuest";
            this.btnGoBackToAddGuest.Size = new System.Drawing.Size(75, 23);
            this.btnGoBackToAddGuest.TabIndex = 32;
            this.btnGoBackToAddGuest.Text = "Go Back";
            this.btnGoBackToAddGuest.UseVisualStyleBackColor = true;
            // 
            // lblCreateReport
            // 
            this.lblCreateReport.AutoSize = true;
            this.lblCreateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateReport.Location = new System.Drawing.Point(90, 56);
            this.lblCreateReport.Name = "lblCreateReport";
            this.lblCreateReport.Size = new System.Drawing.Size(364, 59);
            this.lblCreateReport.TabIndex = 31;
            this.lblCreateReport.Text = "Create Report";
            // 
            // txtHotelID
            // 
            this.txtHotelID.Location = new System.Drawing.Point(193, 126);
            this.txtHotelID.Name = "txtHotelID";
            this.txtHotelID.Size = new System.Drawing.Size(300, 22);
            this.txtHotelID.TabIndex = 43;
            this.txtHotelID.Text = "Greyed out if not managaer";
            // 
            // lblHotelID
            // 
            this.lblHotelID.AutoSize = true;
            this.lblHotelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelID.Location = new System.Drawing.Point(96, 126);
            this.lblHotelID.Name = "lblHotelID";
            this.lblHotelID.Size = new System.Drawing.Size(74, 22);
            this.lblHotelID.TabIndex = 42;
            this.lblHotelID.Text = "Hotel ID";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(96, 221);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(85, 22);
            this.lblEndDate.TabIndex = 47;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(96, 169);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(91, 22);
            this.lblStartDate.TabIndex = 46;
            this.lblStartDate.Text = "Start Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(193, 221);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(251, 22);
            this.dtpEndDate.TabIndex = 45;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(193, 169);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(251, 22);
            this.dtpStartDate.TabIndex = 44;
            // 
            // CreateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 560);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtHotelID);
            this.Controls.Add(this.lblHotelID);
            this.Controls.Add(this.btnGoBackToAddGuest);
            this.Controls.Add(this.lblCreateReport);
            this.Controls.Add(this.btnCreateReport);
            this.Name = "CreateReport";
            this.Text = "CreateReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateReport;
        private System.Windows.Forms.Button btnGoBackToAddGuest;
        private System.Windows.Forms.Label lblCreateReport;
        private System.Windows.Forms.TextBox txtHotelID;
        private System.Windows.Forms.Label lblHotelID;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
    }
}