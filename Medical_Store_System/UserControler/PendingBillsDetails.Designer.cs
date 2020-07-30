namespace Medical_Store_System.UserControler
{
    partial class PendingBillsDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PendingBillsDetails));
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.lblDated = new System.Windows.Forms.Label();
            this.btnPendingBillPaid = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblName.Location = new System.Drawing.Point(101, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(217, 19);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBillAmount.Location = new System.Drawing.Point(101, 31);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(217, 19);
            this.lblBillAmount.TabIndex = 3;
            this.lblBillAmount.Text = "Amount: ";
            // 
            // lblDated
            // 
            this.lblDated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDated.Location = new System.Drawing.Point(101, 52);
            this.lblDated.Name = "lblDated";
            this.lblDated.Size = new System.Drawing.Size(217, 19);
            this.lblDated.TabIndex = 4;
            this.lblDated.Text = "Dated: ";
            // 
            // btnPendingBillPaid
            // 
            this.btnPendingBillPaid.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPendingBillPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPendingBillPaid.FlatAppearance.BorderSize = 2;
            this.btnPendingBillPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendingBillPaid.ForeColor = System.Drawing.Color.White;
            this.btnPendingBillPaid.Location = new System.Drawing.Point(0, 0);
            this.btnPendingBillPaid.Name = "btnPendingBillPaid";
            this.btnPendingBillPaid.Size = new System.Drawing.Size(83, 69);
            this.btnPendingBillPaid.TabIndex = 5;
            this.btnPendingBillPaid.Text = "Paid";
            this.btnPendingBillPaid.UseVisualStyleBackColor = false;
            this.btnPendingBillPaid.Click += new System.EventHandler(this.btnPendingBillPaid_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPendingBillPaid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(318, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 69);
            this.panel1.TabIndex = 6;
            // 
            // PendingBillsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDated);
            this.Controls.Add(this.lblBillAmount);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PendingBillsDetails";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(406, 79);
            this.Load += new System.EventHandler(this.PendingBillsDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.Label lblDated;
        private System.Windows.Forms.Button btnPendingBillPaid;
        private System.Windows.Forms.Panel panel1;
    }
}
