using Medical_Store_System.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MSS_Reporting
{
    public partial class PateintReportPrint : Form
    {
        private List<PateintDetailsModel> patient;
        public PateintReportPrint(List<PateintDetailsModel> patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        private void PateintReportPrint_Load(object sender, EventArgs e)
        {
           
           
            reportViewer.LocalReport.DataSources.Clear();
            ReportDataSource datasource = new ReportDataSource("PateintReportDataSet", patient);
            //datasource.Value = patient;
            reportViewer.LocalReport.DataSources.Add(datasource);
            reportViewer.LocalReport.Refresh();

            this.reportViewer.RefreshReport();
        }
    }
}
