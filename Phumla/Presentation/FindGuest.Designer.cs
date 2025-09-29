namespace Phumla.Presentation
{
    partial class FindGuest
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
            this.lblFindGuestAccount = new System.Windows.Forms.Label();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.pnlExisitingGuests = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnEditGuestAccount = new System.Windows.Forms.Button();
            this.btnRemoveGuestAccount = new System.Windows.Forms.Button();
            this.btnGoBackToAddGuest = new System.Windows.Forms.Button();
            this.pnlExisitingGuests.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFindGuestAccount
            // 
            this.lblFindGuestAccount.AutoSize = true;
            this.lblFindGuestAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindGuestAccount.Location = new System.Drawing.Point(83, 38);
            this.lblFindGuestAccount.Name = "lblFindGuestAccount";
            this.lblFindGuestAccount.Size = new System.Drawing.Size(498, 59);
            this.lblFindGuestAccount.TabIndex = 1;
            this.lblFindGuestAccount.Text = "Find Guest Account";
            // 
            // lblGuestID
            // 
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestID.Location = new System.Drawing.Point(93, 108);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(80, 22);
            this.lblGuestID.TabIndex = 6;
            this.lblGuestID.Text = "Guest ID";
            // 
            // txtGuestID
            // 
            this.txtGuestID.Location = new System.Drawing.Point(191, 110);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(293, 22);
            this.txtGuestID.TabIndex = 7;
            this.txtGuestID.Text = "As text change, the list below changes real time";
            // 
            // pnlExisitingGuests
            // 
            this.pnlExisitingGuests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExisitingGuests.Controls.Add(this.listView1);
            this.pnlExisitingGuests.Location = new System.Drawing.Point(93, 138);
            this.pnlExisitingGuests.Name = "pnlExisitingGuests";
            this.pnlExisitingGuests.Size = new System.Drawing.Size(854, 480);
            this.pnlExisitingGuests.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(846, 472);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnEditGuestAccount
            // 
            this.btnEditGuestAccount.Location = new System.Drawing.Point(93, 637);
            this.btnEditGuestAccount.Name = "btnEditGuestAccount";
            this.btnEditGuestAccount.Size = new System.Drawing.Size(165, 33);
            this.btnEditGuestAccount.TabIndex = 9;
            this.btnEditGuestAccount.Text = "Edit Guest Account";
            this.btnEditGuestAccount.UseVisualStyleBackColor = true;
            // 
            // btnRemoveGuestAccount
            // 
            this.btnRemoveGuestAccount.Location = new System.Drawing.Point(287, 637);
            this.btnRemoveGuestAccount.Name = "btnRemoveGuestAccount";
            this.btnRemoveGuestAccount.Size = new System.Drawing.Size(165, 33);
            this.btnRemoveGuestAccount.TabIndex = 10;
            this.btnRemoveGuestAccount.Text = "Remove Guest Account";
            this.btnRemoveGuestAccount.UseVisualStyleBackColor = true;
            // 
            // btnGoBackToAddGuest
            // 
            this.btnGoBackToAddGuest.Location = new System.Drawing.Point(12, 12);
            this.btnGoBackToAddGuest.Name = "btnGoBackToAddGuest";
            this.btnGoBackToAddGuest.Size = new System.Drawing.Size(75, 23);
            this.btnGoBackToAddGuest.TabIndex = 31;
            this.btnGoBackToAddGuest.Text = "Go Back";
            this.btnGoBackToAddGuest.UseVisualStyleBackColor = true;
            // 
            // FindGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 691);
            this.Controls.Add(this.btnGoBackToAddGuest);
            this.Controls.Add(this.btnRemoveGuestAccount);
            this.Controls.Add(this.btnEditGuestAccount);
            this.Controls.Add(this.pnlExisitingGuests);
            this.Controls.Add(this.txtGuestID);
            this.Controls.Add(this.lblGuestID);
            this.Controls.Add(this.lblFindGuestAccount);
            this.Name = "FindGuest";
            this.Text = "Find Guest Account";
            this.pnlExisitingGuests.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFindGuestAccount;
        private System.Windows.Forms.Label lblGuestID;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.Panel pnlExisitingGuests;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnEditGuestAccount;
        private System.Windows.Forms.Button btnRemoveGuestAccount;
        private System.Windows.Forms.Button btnGoBackToAddGuest;
    }
}