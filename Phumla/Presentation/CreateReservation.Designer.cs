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
            this.SuspendLayout();
            // 
            // lblAddGuest
            // 
            this.lblAddGuest.AutoSize = true;
            this.lblAddGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGuest.Location = new System.Drawing.Point(123, 44);
            this.lblAddGuest.Name = "lblAddGuest";
            this.lblAddGuest.Size = new System.Drawing.Size(535, 59);
            this.lblAddGuest.TabIndex = 18;
            this.lblAddGuest.Text = "Create a Reservation";
            // 
            // CreateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 641);
            this.Controls.Add(this.lblAddGuest);
            this.Name = "CreateReservation";
            this.Text = "Create a Guest Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddGuest;
    }
}