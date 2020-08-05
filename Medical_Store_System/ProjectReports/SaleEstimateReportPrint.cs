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
    public partial class SaleEstimateReportPrint : Form
    {
        private string[] fromToDate;
        private List<SaleEstimateReportModel> list;
        private object pateintCount;

        public SaleEstimateReportPrint(string[] fromToDate, List<SaleEstimateReportModel> list)
        {
            InitializeComponent();
            this.fromToDate = fromToDate;
            this.list = list;
        }

        public SaleEstimateReportPrint(string[] fromToDate, List<SaleEstimateReportModel> list, object pateintCount) : this(fromToDate, list)
        {

            this.pateintCount = pateintCount;
        }

        private void SaleEstimateReportPrint_Load(object sender, EventArgs e)
        {
            DateTime fromDate = Convert.ToDateTime(fromToDate[0]);
            DateTime toDate = Convert.ToDateTime(fromToDate[1]);
            string DrName = "Dr. Hazrat Ali Khan. Technician, Pishawer. (RCCD) & MBBS Canada";
            SaleEstimateReportModelBindingSource.DataSource = list;
            ReportParameter[] p = new ReportParameter[]
            {
                new ReportParameter("paraFromDate",fromDate.ToString("MM/dd/yyyy")),
                new ReportParameter("paraToDate",toDate.ToString("MM/dd/yyyy")),
                new ReportParameter("paraDrName",DrName),
                new ReportParameter("paraSyrupCount","No value"),
                new ReportParameter("paraTabletCount","No value"),
                new ReportParameter("paraInjCount","No value"),
                new ReportParameter("paraOthersCount","No value"),
                new ReportParameter("paraPatientsCount",pateintCount.ToString())

            };
            this.reportViewerSaleEstimate.LocalReport.SetParameters(p);
            reportViewerSaleEstimate.LocalReport.DataSources.Clear();
            ReportDataSource datasource = new ReportDataSource("SaleEstimateDataSet", list);
            reportViewerSaleEstimate.LocalReport.DataSources.Add(datasource);
            reportViewerSaleEstimate.LocalReport.Refresh();
            this.reportViewerSaleEstimate.RefreshReport();
        }
    }
}
