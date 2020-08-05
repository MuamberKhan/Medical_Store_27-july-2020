namespace Medical_Store_System.ProjectReports
{
    partial class PatientPrintReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientPrintReport));
            this.reportViewerPatient = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PatientReportModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PatientReportModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerPatient
            // 
            this.reportViewerPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PateintReportDataSet";
            reportDataSource1.Value = this.PatientReportModelBindingSource;
            reportDataSource2.Name = "PatientRecordReportDataSet";
            reportDataSource2.Value = this.PatientReportModelBindingSource;
            this.reportViewerPatient.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerPatient.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerPatient.LocalReport.ReportEmbeddedResource = "Medical_Store_System.ProjectReports.ReportPatient.rdlc";
            this.reportViewerPatient.Location = new System.Drawing.Point(5, 0);
            this.reportViewerPatient.Name = "reportViewerPatient";
            this.reportViewerPatient.Size = new System.Drawing.Size(601, 406);
            this.reportViewerPatient.TabIndex = 0;
            // 
            // PatientReportModelBindingSource
            // 
            this.PatientReportModelBindingSource.DataSource = typeof(Medical_Store_System.Models.PatientReportModel);
            // 
            // PatientPrintReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(611, 411);
            this.Controls.Add(this.reportViewerPatient);
            this.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientPrintReport";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Report";
            this.Load += new System.EventHandler(this.PatientPrintReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientReportModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPatient;
        private System.Windows.Forms.BindingSource PatientReportModelBindingSource;
    }
}