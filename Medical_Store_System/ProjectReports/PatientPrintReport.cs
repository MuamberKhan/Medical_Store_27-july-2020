using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medical_Store_System.Models;
using Microsoft.Reporting.WinForms;

namespace Medical_Store_System.ProjectReports
{
    public partial class PatientPrintReport : Form
    {
        private PatientReportModel model;
        

        public PatientPrintReport(PatientReportModel model)
        {
            InitializeComponent();
            this.model = model;
        }
        
        private void PatientPrintReport_Load(object sender, EventArgs e)
        {


            reportViewerPatient.LocalReport.DataSources.Clear();
            ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
           {
                new ReportParameter("paraPatientID",model.ID.ToString()),
                new ReportParameter("paraPatientName",model.PatientName),
                new ReportParameter("paraPatientFatherName",model.FatherName),
                new ReportParameter("paraPatientAddress",model.PatientAddress),
                new ReportParameter("paraPatientGender",model.PatientGender)

           };
            this.reportViewerPatient.LocalReport.SetParameters(p);
            ReportDataSource datasource = new ReportDataSource("PatientRecordReportDataSet", model.PateintRecords);
            //datasource.Value = patient;
            reportViewerPatient.LocalReport.DataSources.Add(datasource);
            reportViewerPatient.LocalReport.Refresh();

            this.reportViewerPatient.RefreshReport();
        }
    }
}
