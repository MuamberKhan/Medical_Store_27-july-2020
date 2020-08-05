namespace Medical_Store_System
{
    partial class medicinesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medicinesForm));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnGoPatients = new System.Windows.Forms.Button();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.btnOpenCalclator = new System.Windows.Forms.Button();
            this.btnGoHome = new System.Windows.Forms.Button();
            this.btnShowPOS = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxMedSearch = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchMedicine = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MedSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridViewMedicines = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedPurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cmboBxMedType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHiddenID = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveMedicine = new System.Windows.Forms.Button();
            this.btnCancelMedicine = new System.Windows.Forms.Button();
            this.numUpDwnQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMedOrigPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMedSellPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMedName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMedicines)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnGoPatients
            // 
            this.btnGoPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoPatients.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F);
            this.btnGoPatients.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGoPatients.Image = ((System.Drawing.Image)(resources.GetObject("btnGoPatients.Image")));
            this.btnGoPatients.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoPatients.Location = new System.Drawing.Point(12, 239);
            this.btnGoPatients.Name = "btnGoPatients";
            this.btnGoPatients.Size = new System.Drawing.Size(144, 47);
            this.btnGoPatients.TabIndex = 2;
            this.btnGoPatients.Text = "Patients";
            this.btnGoPatients.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGoPatients.UseVisualStyleBackColor = true;
            this.btnGoPatients.Click += new System.EventHandler(this.btnGoPatients_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitApp.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F);
            this.btnExitApp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExitApp.Image = ((System.Drawing.Image)(resources.GetObject("btnExitApp.Image")));
            this.btnExitApp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExitApp.Location = new System.Drawing.Point(12, 392);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(144, 47);
            this.btnExitApp.TabIndex = 3;
            this.btnExitApp.Text = "Exit";
            this.btnExitApp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // btnOpenCalclator
            // 
            this.btnOpenCalclator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCalclator.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F);
            this.btnOpenCalclator.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOpenCalclator.Location = new System.Drawing.Point(12, 341);
            this.btnOpenCalclator.Name = "btnOpenCalclator";
            this.btnOpenCalclator.Size = new System.Drawing.Size(144, 47);
            this.btnOpenCalclator.TabIndex = 4;
            this.btnOpenCalclator.Text = "Calculator";
            this.btnOpenCalclator.UseVisualStyleBackColor = true;
            // 
            // btnGoHome
            // 
            this.btnGoHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoHome.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F);
            this.btnGoHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGoHome.Image = ((System.Drawing.Image)(resources.GetObject("btnGoHome.Image")));
            this.btnGoHome.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGoHome.Location = new System.Drawing.Point(12, 187);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(144, 51);
            this.btnGoHome.TabIndex = 5;
            this.btnGoHome.Text = "DashBoard";
            this.btnGoHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGoHome.UseVisualStyleBackColor = true;
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // btnShowPOS
            // 
            this.btnShowPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPOS.Font = new System.Drawing.Font("Rockwell Condensed", 15.75F);
            this.btnShowPOS.ForeColor = System.Drawing.SystemColors.Control;
            this.btnShowPOS.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPOS.Image")));
            this.btnShowPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowPOS.Location = new System.Drawing.Point(12, 290);
            this.btnShowPOS.Name = "btnShowPOS";
            this.btnShowPOS.Size = new System.Drawing.Size(144, 47);
            this.btnShowPOS.TabIndex = 7;
            this.btnShowPOS.Text = "Medicines";
            this.btnShowPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnShowPOS.UseVisualStyleBackColor = true;
            this.btnShowPOS.Click += new System.EventHandler(this.btnShowPOS_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnShowPOS);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnGoHome);
            this.panel1.Controls.Add(this.btnOpenCalclator);
            this.panel1.Controls.Add(this.btnExitApp);
            this.panel1.Controls.Add(this.btnGoPatients);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 595);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(172, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 86);
            this.panel2.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Rockwell Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(92, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 44);
            this.label10.TabIndex = 31;
            this.label10.Text = "Add New";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.comboBoxMedSearch);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtSearchMedicine);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(414, -1);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(356, 84);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(304, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 29);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboBoxMedSearch
            // 
            this.comboBoxMedSearch.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.comboBoxMedSearch.FormattingEnabled = true;
            this.comboBoxMedSearch.Items.AddRange(new object[] {
            "Syrup",
            "Injection",
            "Tablets",
            "Drip",
            "Other"});
            this.comboBoxMedSearch.Location = new System.Drawing.Point(169, 41);
            this.comboBoxMedSearch.Name = "comboBoxMedSearch";
            this.comboBoxMedSearch.Size = new System.Drawing.Size(129, 25);
            this.comboBoxMedSearch.TabIndex = 26;
            this.comboBoxMedSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchMedicine_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(152, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "By Type";
            // 
            // txtSearchMedicine
            // 
            this.txtSearchMedicine.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.txtSearchMedicine.Location = new System.Drawing.Point(12, 41);
            this.txtSearchMedicine.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearchMedicine.Name = "txtSearchMedicine";
            this.txtSearchMedicine.Size = new System.Drawing.Size(152, 24);
            this.txtSearchMedicine.TabIndex = 1;
            this.txtSearchMedicine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchMedicine_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(9, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "By Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MedSellPrice
            // 
            this.MedSellPrice.DataPropertyName = "MedSellPrice";
            this.MedSellPrice.HeaderText = "Selling Price";
            this.MedSellPrice.Name = "MedSellPrice";
            this.MedSellPrice.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.gridViewMedicines);
            this.panel3.Controls.Add(this.statusStrip1);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(172, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(772, 509);
            this.panel3.TabIndex = 2;
            // 
            // gridViewMedicines
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gridViewMedicines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewMedicines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewMedicines.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridViewMedicines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridViewMedicines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.gridViewMedicines.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.gridViewMedicines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 10.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.NullValue = "Not Set";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.gridViewMedicines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewMedicines.ColumnHeadersHeight = 40;
            this.gridViewMedicines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MedName,
            this.Quantity,
            this.MedPurchasePrice});
            this.gridViewMedicines.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Rockwell", 10.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewMedicines.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewMedicines.Location = new System.Drawing.Point(17, 250);
            this.gridViewMedicines.Name = "gridViewMedicines";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Rockwell", 10.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewMedicines.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridViewMedicines.RowTemplate.Height = 30;
            this.gridViewMedicines.RowTemplate.ReadOnly = true;
            this.gridViewMedicines.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewMedicines.Size = new System.Drawing.Size(744, 217);
            this.gridViewMedicines.TabIndex = 23;
            this.gridViewMedicines.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewMedicines_CellContentDoubleClick);
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
            this.MedName.DataPropertyName = "MedName";
            this.MedName.HeaderText = "Name";
            this.MedName.Name = "MedName";
            this.MedName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // MedPurchasePrice
            // 
            this.MedPurchasePrice.DataPropertyName = "MedPurchasePrice";
            this.MedPurchasePrice.HeaderText = "Purchase Price";
            this.MedPurchasePrice.Name = "MedPurchasePrice";
            this.MedPurchasePrice.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 482);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(772, 27);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStatus.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Italic);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 22);
            this.lblStatus.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblUnit);
            this.groupBox1.Controls.Add(this.cmboBxMedType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtHiddenID);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSaveMedicine);
            this.groupBox1.Controls.Add(this.btnCancelMedicine);
            this.groupBox1.Controls.Add(this.numUpDwnQuantity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMedOrigPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMedSellPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMedName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(730, 216);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Medicine";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.textBox1.Location = new System.Drawing.Point(129, 117);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 24);
            this.textBox1.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(22, 120);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Comp. Name";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.txtDiscount.Location = new System.Drawing.Point(129, 58);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDiscount.MaxLength = 3;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(131, 24);
            this.txtDiscount.TabIndex = 27;
            this.txtDiscount.Text = "10";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtMedSellPrice_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(22, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Discount in %";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Rockwell", 12F);
            this.lblUnit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUnit.Location = new System.Drawing.Point(428, 89);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(57, 19);
            this.lblUnit.TabIndex = 25;
            this.lblUnit.Text = "Bottles";
            // 
            // cmboBxMedType
            // 
            this.cmboBxMedType.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.cmboBxMedType.FormattingEnabled = true;
            this.cmboBxMedType.Items.AddRange(new object[] {
            "Syrup",
            "Injection",
            "Tablets",
            "Drip",
            "Other"});
            this.cmboBxMedType.Location = new System.Drawing.Point(129, 28);
            this.cmboBxMedType.Name = "cmboBxMedType";
            this.cmboBxMedType.Size = new System.Drawing.Size(131, 25);
            this.cmboBxMedType.TabIndex = 24;
            this.cmboBxMedType.SelectedIndexChanged += new System.EventHandler(this.cmboBxMedType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(22, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Medicine Type";
            // 
            // txtHiddenID
            // 
            this.txtHiddenID.Font = new System.Drawing.Font("Rockwell", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHiddenID.Location = new System.Drawing.Point(4, 20);
            this.txtHiddenID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtHiddenID.Name = "txtHiddenID";
            this.txtHiddenID.Size = new System.Drawing.Size(23, 16);
            this.txtHiddenID.TabIndex = 13;
            this.txtHiddenID.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.txtDescription.Location = new System.Drawing.Point(511, 48);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(205, 64);
            this.txtDescription.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(508, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Description";
            // 
            // btnSaveMedicine
            // 
            this.btnSaveMedicine.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveMedicine.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveMedicine.FlatAppearance.BorderSize = 4;
            this.btnSaveMedicine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSaveMedicine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaveMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveMedicine.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.btnSaveMedicine.ForeColor = System.Drawing.Color.White;
            this.btnSaveMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveMedicine.Image")));
            this.btnSaveMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveMedicine.Location = new System.Drawing.Point(612, 162);
            this.btnSaveMedicine.Name = "btnSaveMedicine";
            this.btnSaveMedicine.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnSaveMedicine.Size = new System.Drawing.Size(113, 43);
            this.btnSaveMedicine.TabIndex = 10;
            this.btnSaveMedicine.Text = "Save";
            this.btnSaveMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSaveMedicine.UseVisualStyleBackColor = false;
            this.btnSaveMedicine.Click += new System.EventHandler(this.btnSaveMedicine_Click);
            // 
            // btnCancelMedicine
            // 
            this.btnCancelMedicine.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancelMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelMedicine.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelMedicine.FlatAppearance.BorderSize = 4;
            this.btnCancelMedicine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancelMedicine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelMedicine.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.btnCancelMedicine.ForeColor = System.Drawing.Color.White;
            this.btnCancelMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelMedicine.Image")));
            this.btnCancelMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelMedicine.Location = new System.Drawing.Point(493, 162);
            this.btnCancelMedicine.Name = "btnCancelMedicine";
            this.btnCancelMedicine.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnCancelMedicine.Size = new System.Drawing.Size(110, 43);
            this.btnCancelMedicine.TabIndex = 9;
            this.btnCancelMedicine.Text = "Cancel";
            this.btnCancelMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelMedicine.UseVisualStyleBackColor = false;
            this.btnCancelMedicine.Click += new System.EventHandler(this.btnCancelMedicine_Click);
            // 
            // numUpDwnQuantity
            // 
            this.numUpDwnQuantity.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.numUpDwnQuantity.Location = new System.Drawing.Point(363, 86);
            this.numUpDwnQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numUpDwnQuantity.Name = "numUpDwnQuantity";
            this.numUpDwnQuantity.Size = new System.Drawing.Size(61, 24);
            this.numUpDwnQuantity.TabIndex = 8;
            this.numUpDwnQuantity.ThousandsSeparator = true;
            this.numUpDwnQuantity.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(280, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity";
            // 
            // txtMedOrigPrice
            // 
            this.txtMedOrigPrice.Enabled = false;
            this.txtMedOrigPrice.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.txtMedOrigPrice.Location = new System.Drawing.Point(129, 86);
            this.txtMedOrigPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMedOrigPrice.Name = "txtMedOrigPrice";
            this.txtMedOrigPrice.Size = new System.Drawing.Size(131, 24);
            this.txtMedOrigPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(22, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Original Price";
            // 
            // txtMedSellPrice
            // 
            this.txtMedSellPrice.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.txtMedSellPrice.Location = new System.Drawing.Point(363, 58);
            this.txtMedSellPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMedSellPrice.Name = "txtMedSellPrice";
            this.txtMedSellPrice.Size = new System.Drawing.Size(119, 24);
            this.txtMedSellPrice.TabIndex = 3;
            this.txtMedSellPrice.TextChanged += new System.EventHandler(this.txtMedSellPrice_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(280, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Retail Price";
            // 
            // txtMedName
            // 
            this.txtMedName.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.txtMedName.Location = new System.Drawing.Point(363, 28);
            this.txtMedName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.Size = new System.Drawing.Size(119, 24);
            this.txtMedName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(280, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Med. Name";
            // 
            // medicinesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "medicinesForm";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Medicines";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.medicinesForm_FormClosing);
            this.Load += new System.EventHandler(this.medicinesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMedicines)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxMedSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchMedicine;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowPOS;
        private System.Windows.Forms.Button btnGoHome;
        private System.Windows.Forms.Button btnOpenCalclator;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Button btnGoPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedSellPrice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView gridViewMedicines;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedPurchasePrice;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cmboBxMedType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHiddenID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveMedicine;
        private System.Windows.Forms.Button btnCancelMedicine;
        private System.Windows.Forms.NumericUpDown numUpDwnQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMedOrigPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMedSellPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMedName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}