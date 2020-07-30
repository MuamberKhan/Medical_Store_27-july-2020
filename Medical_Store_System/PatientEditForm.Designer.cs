namespace Medical_Store_System
{
    partial class PatientEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientEditForm));
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHiddenID = new System.Windows.Forms.TextBox();
            this.txtPatDescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPatDiagnosis = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.datePickerAppointment = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmboBxPatType = new System.Windows.Forms.ComboBox();
            this.txtPatName = new System.Windows.Forms.TextBox();
            this.lstSelectedMedicines = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPatTreatment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPatResid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnUpdatePatient = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(416, 44);
            this.label3.TabIndex = 30;
            this.label3.Text = "Edit Patient\'s Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 59);
            this.panel1.TabIndex = 50;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(598, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 45);
            this.btnBack.TabIndex = 17;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.statusStrip);
            this.panel2.Controls.Add(this.btnUpdatePatient);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 343);
            this.panel2.TabIndex = 51;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.txtHiddenID);
            this.groupBox2.Controls.Add(this.txtPatDescription);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtPatDiagnosis);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.datePickerAppointment);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmboBxPatType);
            this.groupBox2.Controls.Add(this.txtPatName);
            this.groupBox2.Controls.Add(this.lstSelectedMedicines);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPatTreatment);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPatResid);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 257);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            // 
            // txtHiddenID
            // 
            this.txtHiddenID.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.txtHiddenID.Location = new System.Drawing.Point(25, 257);
            this.txtHiddenID.Name = "txtHiddenID";
            this.txtHiddenID.Size = new System.Drawing.Size(15, 24);
            this.txtHiddenID.TabIndex = 48;
            // 
            // txtPatDescription
            // 
            this.txtPatDescription.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.txtPatDescription.Location = new System.Drawing.Point(342, 38);
            this.txtPatDescription.Multiline = true;
            this.txtPatDescription.Name = "txtPatDescription";
            this.txtPatDescription.Size = new System.Drawing.Size(243, 71);
            this.txtPatDescription.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 11F);
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(340, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 17);
            this.label10.TabIndex = 47;
            this.label10.Text = "Description/Home Precuations/etc";
            // 
            // txtPatDiagnosis
            // 
            this.txtPatDiagnosis.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.txtPatDiagnosis.Location = new System.Drawing.Point(214, 133);
            this.txtPatDiagnosis.Multiline = true;
            this.txtPatDiagnosis.Name = "txtPatDiagnosis";
            this.txtPatDiagnosis.Size = new System.Drawing.Size(165, 108);
            this.txtPatDiagnosis.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 11F);
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(210, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "Diagnosis";
            // 
            // datePickerAppointment
            // 
            this.datePickerAppointment.CustomFormat = "ddd dd MMM yyyy";
            this.datePickerAppointment.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.datePickerAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerAppointment.Location = new System.Drawing.Point(162, 36);
            this.datePickerAppointment.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datePickerAppointment.Name = "datePickerAppointment";
            this.datePickerAppointment.Size = new System.Drawing.Size(165, 24);
            this.datePickerAppointment.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 11F);
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(159, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Appointment dated";
            // 
            // cmboBxPatType
            // 
            this.cmboBxPatType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmboBxPatType.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.cmboBxPatType.FormattingEnabled = true;
            this.cmboBxPatType.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Kids"});
            this.cmboBxPatType.Location = new System.Drawing.Point(24, 87);
            this.cmboBxPatType.Name = "cmboBxPatType";
            this.cmboBxPatType.Size = new System.Drawing.Size(121, 25);
            this.cmboBxPatType.TabIndex = 33;
            // 
            // txtPatName
            // 
            this.txtPatName.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.txtPatName.Location = new System.Drawing.Point(25, 36);
            this.txtPatName.Name = "txtPatName";
            this.txtPatName.Size = new System.Drawing.Size(121, 24);
            this.txtPatName.TabIndex = 31;
            // 
            // lstSelectedMedicines
            // 
            this.lstSelectedMedicines.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lstSelectedMedicines.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.lstSelectedMedicines.FormattingEnabled = true;
            this.lstSelectedMedicines.ItemHeight = 17;
            this.lstSelectedMedicines.Location = new System.Drawing.Point(385, 136);
            this.lstSelectedMedicines.Name = "lstSelectedMedicines";
            this.lstSelectedMedicines.Size = new System.Drawing.Size(200, 106);
            this.lstSelectedMedicines.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 11F);
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(381, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Prescribed Medicines";
            // 
            // txtPatTreatment
            // 
            this.txtPatTreatment.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.txtPatTreatment.Location = new System.Drawing.Point(25, 133);
            this.txtPatTreatment.Multiline = true;
            this.txtPatTreatment.Name = "txtPatTreatment";
            this.txtPatTreatment.Size = new System.Drawing.Size(165, 108);
            this.txtPatTreatment.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(21, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Treatment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11F);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(21, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Type of Patient";
            // 
            // txtPatResid
            // 
            this.txtPatResid.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.txtPatResid.Location = new System.Drawing.Point(162, 85);
            this.txtPatResid.Name = "txtPatResid";
            this.txtPatResid.Size = new System.Drawing.Size(165, 24);
            this.txtPatResid.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(159, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Place of Residance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 11F);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(21, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Patient Name";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 316);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(654, 27);
            this.statusStrip.TabIndex = 56;
            this.statusStrip.Text = "StatusStrip";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStatus.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Italic);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 22);
            this.lblStatus.Text = "Status";
            // 
            // btnUpdatePatient
            // 
            this.btnUpdatePatient.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdatePatient.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePatient.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePatient.Location = new System.Drawing.Point(94, 271);
            this.btnUpdatePatient.Name = "btnUpdatePatient";
            this.btnUpdatePatient.Size = new System.Drawing.Size(454, 42);
            this.btnUpdatePatient.TabIndex = 53;
            this.btnUpdatePatient.Text = "Update and Proceed";
            this.btnUpdatePatient.UseVisualStyleBackColor = false;
            this.btnUpdatePatient.Click += new System.EventHandler(this.btnUpdateForPrint_Click);
            // 
            // PatientEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(664, 407);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientEditForm";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Edit";
            this.Load += new System.EventHandler(this.PatientEditForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHiddenID;
        private System.Windows.Forms.TextBox txtPatDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPatDiagnosis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker datePickerAppointment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmboBxPatType;
        private System.Windows.Forms.TextBox txtPatName;
        private System.Windows.Forms.ListBox lstSelectedMedicines;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPatTreatment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPatResid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button btnUpdatePatient;
    }
}