namespace Medical_Store_System.ProjectReports
{
    partial class SaleEstimateReportPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleEstimateReportPrint));
            this.reportViewerSaleEstimate = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SaleEstimateReportModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SaleEstimateReportModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerSaleEstimate
            // 
            this.reportViewerSaleEstimate.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SaleEstimateDataSet";
            reportDataSource1.Value = this.SaleEstimateReportModelBindingSource;
            this.reportViewerSaleEstimate.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerSaleEstimate.LocalReport.ReportEmbeddedResource = "Medical_Store_System.ProjectReports.ReportSaleEstimate.rdlc";
            this.reportViewerSaleEstimate.Location = new System.Drawing.Point(5, 0);
            this.reportViewerSaleEstimate.Name = "reportViewerSaleEstimate";
            this.reportViewerSaleEstimate.Size = new System.Drawing.Size(729, 458);
            this.reportViewerSaleEstimate.TabIndex = 0;
            // 
            // SaleEstimateReportModelBindingSource
            // 
            this.SaleEstimateReportModelBindingSource.DataSource = typeof(Medical_Store_System.Models.SaleEstimateReportModel);
            // 
            // SaleEstimateReportPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(739, 463);
            this.Controls.Add(this.reportViewerSaleEstimate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SaleEstimateReportPrint";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Estimate Report Print";
            this.Load += new System.EventHandler(this.SaleEstimateReportPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SaleEstimateReportModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSaleEstimate;
        private System.Windows.Forms.BindingSource SaleEstimateReportModelBindingSource;
    }
}