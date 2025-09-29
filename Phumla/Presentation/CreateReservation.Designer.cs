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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(183, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 22);
            this.dateTimePicker1.TabIndex = 20;
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(632, 175);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(241, 22);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(321, 261);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 23;
            // 
            // CreateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 685);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblCreateReservation);
            this.Name = "CreateReservation";
            this.Text = "Create a New Reservation";
            this.Load += new System.EventHandler(this.CreateBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateReservation;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}