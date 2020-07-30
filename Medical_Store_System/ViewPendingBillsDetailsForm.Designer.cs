namespace Medical_Store_System
{
    partial class ViewPendingBillsDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPendingBillsDetailsForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlListArea = new System.Windows.Forms.Panel();
            this.lblNoPendingBills = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnlListArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 53);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(40, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(446, 22);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Follwing is the list of all Unpaid bill according to the Borrower name.";
            // 
            // pnlListArea
            // 
            this.pnlListArea.AutoScroll = true;
            this.pnlListArea.BackColor = System.Drawing.SystemColors.Control;
            this.pnlListArea.Controls.Add(this.lblNoPendingBills);
            this.pnlListArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListArea.Location = new System.Drawing.Point(5, 53);
            this.pnlListArea.Name = "pnlListArea";
            this.pnlListArea.Size = new System.Drawing.Size(540, 280);
            this.pnlListArea.TabIndex = 2;
            // 
            // lblNoPendingBills
            // 
            this.lblNoPendingBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoPendingBills.Font = new System.Drawing.Font("Rockwell Condensed", 24.25F);
            this.lblNoPendingBills.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNoPendingBills.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNoPendingBills.Location = new System.Drawing.Point(106, 67);
            this.lblNoPendingBills.Name = "lblNoPendingBills";
            this.lblNoPendingBills.Size = new System.Drawing.Size(307, 84);
            this.lblNoPendingBills.TabIndex = 7;
            this.lblNoPendingBills.Text = "No pending bills for now!";
            this.lblNoPendingBills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoPendingBills.Visible = false;
            // 
            // ViewPendingBillsDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(550, 338);
            this.Controls.Add(this.pnlListArea);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewPendingBillsDetailsForm";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Patient Details";
            this.Load += new System.EventHandler(this.ViewPatientDetailsForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlListArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlListArea;
        private System.Windows.Forms.Label lblNoPendingBills;
    }
}