using System;

namespace Medical_Store_System
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGoHome = new System.Windows.Forms.Button();
            this.btnOpenCalclator = new System.Windows.Forms.Button();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.btnGoPateints = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSearchPateint = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtPatDescription = new System.Windows.Forms.TextBox();
            this.txtPatTreatment = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatDiagnosis = new System.Windows.Forms.TextBox();
            this.datePickerAppointment = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lstSelectedMedicines = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPatName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHiddenID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatResid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmboBxPatType = new System.Windows.Forms.ComboBox();
            this.dataGridPatients = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.PatientGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSavePatient = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstAllMedicines = new System.Windows.Forms.ListBox();
            this.txtSearchInListBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPatients)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnGoHome);
            this.panel1.Controls.Add(this.btnOpenCalclator);
            this.panel1.Controls.Add(this.btnExitApp);
            this.panel1.Controls.Add(this.btnGoPateints);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 595);
            this.panel1.TabIndex = 0;
            // 
            // btnGoHome
            // 
            this.btnGoHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoHome.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F);
            this.btnGoHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGoHome.Location = new System.Drawing.Point(23, 186);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(100, 35);
            this.btnGoHome.TabIndex = 9;
            this.btnGoHome.Text = "Home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // btnOpenCalclator
            // 
            this.btnOpenCalclator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCalclator.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F);
            this.btnOpenCalclator.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOpenCalclator.Location = new System.Drawing.Point(21, 241);
            this.btnOpenCalclator.Name = "btnOpenCalclator";
            this.btnOpenCalclator.Size = new System.Drawing.Size(100, 35);
            this.btnOpenCalclator.TabIndex = 8;
            this.btnOpenCalclator.Text = "Calculator";
            this.btnOpenCalclator.UseVisualStyleBackColor = true;
            // 
            // btnExitApp
            // 
            this.btnExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitApp.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F);
            this.btnExitApp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExitApp.Location = new System.Drawing.Point(21, 351);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(100, 35);
            this.btnExitApp.TabIndex = 7;
            this.btnExitApp.Text = "Exit";
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // btnGoPateints
            // 
            this.btnGoPateints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoPateints.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F);
            this.btnGoPateints.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGoPateints.Location = new System.Drawing.Point(21, 296);
            this.btnGoPateints.Name = "btnGoPateints";
            this.btnGoPateints.Size = new System.Drawing.Size(100, 35);
            this.btnGoPateints.TabIndex = 6;
            this.btnGoPateints.Text = "Medicines";
            this.btnGoPateints.UseVisualStyleBackColor = true;
            this.btnGoPateints.Click += new System.EventHandler(this.btnGoPateints_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(145, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 84);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.txtSearchPateint);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Rockwell", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(687, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 73);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(280, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 29);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtSearchPateint
            // 
            this.txtSearchPateint.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.txtSearchPateint.Location = new System.Drawing.Point(96, 33);
            this.txtSearchPateint.Multiline = true;
            this.txtSearchPateint.Name = "txtSearchPateint";
            this.txtSearchPateint.Size = new System.Drawing.Size(222, 29);
            this.txtSearchPateint.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(17, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "By Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(94, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 44);
            this.label6.TabIndex = 34;
            this.label6.Text = "Add New";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.dataGridPatients);
            this.panel3.Controls.Add(this.statusStrip1);
            this.panel3.Controls.Add(this.btnSavePatient);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(145, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1034, 511);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 368);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register New Patient";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPatDescription);
            this.groupBox5.Controls.Add(this.txtPatTreatment);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtPatDiagnosis);
            this.groupBox5.Controls.Add(this.datePickerAppointment);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.lstSelectedMedicines);
            this.groupBox5.Location = new System.Drawing.Point(17, 121);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(708, 230);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pateint Medical Record";
            // 
            // txtPatDescription
            // 
            this.txtPatDescription.Font = new System.Drawing.Font("Rockwell", 10F);
            this.txtPatDescription.Location = new System.Drawing.Point(15, 167);
            this.txtPatDescription.Multiline = true;
            this.txtPatDescription.Name = "txtPatDescription";
            this.txtPatDescription.Size = new System.Drawing.Size(510, 51);
            this.txtPatDescription.TabIndex = 31;
            // 
            // txtPatTreatment
            // 
            this.txtPatTreatment.Font = new System.Drawing.Font("Rockwell", 10F);
            this.txtPatTreatment.Location = new System.Drawing.Point(15, 102);
            this.txtPatTreatment.Multiline = true;
            this.txtPatTreatment.Name = "txtPatTreatment";
            this.txtPatTreatment.Size = new System.Drawing.Size(510, 42);
            this.txtPatTreatment.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(13, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "Description/Home Precuations/etc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Treatment";
            // 
            // txtPatDiagnosis
            // 
            this.txtPatDiagnosis.Font = new System.Drawing.Font("Rockwell", 10F);
            this.txtPatDiagnosis.Location = new System.Drawing.Point(169, 49);
            this.txtPatDiagnosis.Multiline = true;
            this.txtPatDiagnosis.Name = "txtPatDiagnosis";
            this.txtPatDiagnosis.Size = new System.Drawing.Size(356, 47);
            this.txtPatDiagnosis.TabIndex = 30;
            // 
            // datePickerAppointment
            // 
            this.datePickerAppointment.CustomFormat = "ddd dd MMM yyyy";
            this.datePickerAppointment.Font = new System.Drawing.Font("Rockwell", 10F);
            this.datePickerAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerAppointment.Location = new System.Drawing.Point(16, 49);
            this.datePickerAppointment.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datePickerAppointment.Name = "datePickerAppointment";
            this.datePickerAppointment.Size = new System.Drawing.Size(130, 23);
            this.datePickerAppointment.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(530, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Prescribed Medicines";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(13, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Appointment dated";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(166, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Diagnosis";
            // 
            // lstSelectedMedicines
            // 
            this.lstSelectedMedicines.BackColor = System.Drawing.SystemColors.Control;
            this.lstSelectedMedicines.Font = new System.Drawing.Font("Rockwell", 10F);
            this.lstSelectedMedicines.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lstSelectedMedicines.FormattingEnabled = true;
            this.lstSelectedMedicines.ItemHeight = 16;
            this.lstSelectedMedicines.Location = new System.Drawing.Point(533, 53);
            this.lstSelectedMedicines.Name = "lstSelectedMedicines";
            this.lstSelectedMedicines.Size = new System.Drawing.Size(165, 164);
            this.lstSelectedMedicines.TabIndex = 34;
            this.lstSelectedMedicines.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstSelectedMedicines_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFatherName);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtPatName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtHiddenID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPatResid);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmboBxPatType);
            this.groupBox2.Location = new System.Drawing.Point(17, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(708, 85);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Credentials";
            // 
            // txtFatherName
            // 
            this.txtFatherName.Font = new System.Drawing.Font("Rockwell", 10F);
            this.txtFatherName.Location = new System.Drawing.Point(204, 50);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(160, 23);
            this.txtFatherName.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(201, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Father/Guardian  Name";
            // 
            // txtPatName
            // 
            this.txtPatName.Font = new System.Drawing.Font("Rockwell", 10F);
            this.txtPatName.Location = new System.Drawing.Point(29, 50);
            this.txtPatName.Name = "txtPatName";
            this.txtPatName.Size = new System.Drawing.Size(151, 23);
            this.txtPatName.TabIndex = 1;
            this.txtPatName.LostFocus += txtPatName_LostFocus;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Name";
            // 
            // txtHiddenID
            // 
            this.txtHiddenID.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.txtHiddenID.Location = new System.Drawing.Point(8, 48);
            this.txtHiddenID.Name = "txtHiddenID";
            this.txtHiddenID.Size = new System.Drawing.Size(15, 24);
            this.txtHiddenID.TabIndex = 29;
            this.txtHiddenID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(530, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Place of Residance";
            // 
            // txtPatResid
            // 
            this.txtPatResid.Font = new System.Drawing.Font("Rockwell", 10F);
            this.txtPatResid.Location = new System.Drawing.Point(533, 50);
            this.txtPatResid.Name = "txtPatResid";
            this.txtPatResid.Size = new System.Drawing.Size(121, 23);
            this.txtPatResid.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(392, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type of Patient";
            // 
            // cmboBxPatType
            // 
            this.cmboBxPatType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmboBxPatType.Font = new System.Drawing.Font("Rockwell", 10F);
            this.cmboBxPatType.FormattingEnabled = true;
            this.cmboBxPatType.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Kids"});
            this.cmboBxPatType.Location = new System.Drawing.Point(393, 49);
            this.cmboBxPatType.Name = "cmboBxPatType";
            this.cmboBxPatType.Size = new System.Drawing.Size(121, 24);
            this.cmboBxPatType.TabIndex = 3;
            // 
            // dataGridPatients
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPatients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridPatients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridPatients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridPatients.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridPatients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.NullValue = "Not Set";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPatients.ColumnHeadersHeight = 40;
            this.dataGridPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MedName,
            this.PatientGender,
            this.PatientAddress,
            this.AppointmentDate});
            this.dataGridPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridPatients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridPatients.Location = new System.Drawing.Point(0, 384);
            this.dataGridPatients.Name = "dataGridPatients";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPatients.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridPatients.RowTemplate.Height = 35;
            this.dataGridPatients.RowTemplate.ReadOnly = true;
            this.dataGridPatients.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPatients.Size = new System.Drawing.Size(1034, 100);
            this.dataGridPatients.TabIndex = 28;
            this.dataGridPatients.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPatients_CellContentDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.ID.DefaultCellStyle = dataGridViewCellStyle3;
            this.ID.HeaderText = "Identity";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // MedName
            // 
            this.MedName.DataPropertyName = "PatientName";
            this.MedName.HeaderText = "Name";
            this.MedName.Name = "MedName";
            this.MedName.ReadOnly = true;
            this.MedName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MedName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PatientGender
            // 
            this.PatientGender.DataPropertyName = "PatientGender";
            this.PatientGender.HeaderText = "Gender";
            this.PatientGender.Name = "PatientGender";
            // 
            // PatientAddress
            // 
            this.PatientAddress.DataPropertyName = "PatientAddress";
            this.PatientAddress.HeaderText = "Address";
            this.PatientAddress.Name = "PatientAddress";
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.DataPropertyName = "AppointmentDate";
            this.AppointmentDate.HeaderText = "Appointment On";
            this.AppointmentDate.Name = "AppointmentDate";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1034, 27);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStatus.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Italic);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(197, 22);
            this.lblStatus.Text = "toolStripStatusLabel1";
            // 
            // btnSavePatient
            // 
            this.btnSavePatient.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSavePatient.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSavePatient.FlatAppearance.BorderSize = 4;
            this.btnSavePatient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSavePatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSavePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePatient.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.btnSavePatient.ForeColor = System.Drawing.Color.White;
            this.btnSavePatient.Image = ((System.Drawing.Image)(resources.GetObject("btnSavePatient.Image")));
            this.btnSavePatient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSavePatient.Location = new System.Drawing.Point(911, 321);
            this.btnSavePatient.Name = "btnSavePatient";
            this.btnSavePatient.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnSavePatient.Size = new System.Drawing.Size(106, 43);
            this.btnSavePatient.TabIndex = 35;
            this.btnSavePatient.Text = "Save";
            this.btnSavePatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSavePatient.UseVisualStyleBackColor = false;
            this.btnSavePatient.Click += new System.EventHandler(this.btnSavePatient_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatAppearance.BorderSize = 4;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(792, 321);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnCancel.Size = new System.Drawing.Size(106, 43);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.lstAllMedicines);
            this.groupBox4.Controls.Add(this.txtSearchInListBox);
            this.groupBox4.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox4.Location = new System.Drawing.Point(776, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(246, 308);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search for medicines";
            // 
            // lstAllMedicines
            // 
            this.lstAllMedicines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAllMedicines.Font = new System.Drawing.Font("Rockwell", 10F);
            this.lstAllMedicines.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lstAllMedicines.FormattingEnabled = true;
            this.lstAllMedicines.ItemHeight = 16;
            this.lstAllMedicines.Location = new System.Drawing.Point(5, 51);
            this.lstAllMedicines.Name = "lstAllMedicines";
            this.lstAllMedicines.Size = new System.Drawing.Size(236, 252);
            this.lstAllMedicines.TabIndex = 10;
            this.lstAllMedicines.DoubleClick += new System.EventHandler(this.lstAllMedicines_DoubleClick);
            this.lstAllMedicines.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchInListBox_KeyPress);
            // 
            // txtSearchInListBox
            // 
            this.txtSearchInListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearchInListBox.Font = new System.Drawing.Font("Rockwell", 10F);
            this.txtSearchInListBox.Location = new System.Drawing.Point(5, 28);
            this.txtSearchInListBox.Name = "txtSearchInListBox";
            this.txtSearchInListBox.Size = new System.Drawing.Size(236, 23);
            this.txtSearchInListBox.TabIndex = 8;
            this.txtSearchInListBox.TextChanged += new System.EventHandler(this.txtSearchInListBox_TextChanged);
            this.txtSearchInListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchInListBox_KeyPress);
            // 
            // PatientForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PatientForm";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatientForm_FormClosing);
            this.Load += new System.EventHandler(this.patientForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPatients)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

      

        private void txtPatName_LostFocus1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void TxtPatName_LostFocus(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSearchPateint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGoHome;
        private System.Windows.Forms.Button btnOpenCalclator;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Button btnGoPateints;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewLinkColumn MedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentDate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHiddenID;
        private System.Windows.Forms.DateTimePicker datePickerAppointment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmboBxPatType;
        private System.Windows.Forms.TextBox txtPatName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPatResid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSearchInListBox;
        private System.Windows.Forms.ListBox lstAllMedicines;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSavePatient;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPatDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPatDiagnosis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstSelectedMedicines;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPatTreatment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label label11;
    }
}