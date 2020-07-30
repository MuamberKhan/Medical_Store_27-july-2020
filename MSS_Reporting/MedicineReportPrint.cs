using MedicineReport;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSS_Reporting
{
    public partial class MedicineReportPrint : Form
    {
        string[] fromToDate;
        List<MedicineReportData> _list;
        public MedicineReportPrint(string[] fromToDate,List<MedicineReportData> list)
        {
            InitializeComponent();
           this.fromToDate=fromToDate;
             _list = list;

        }

        private void fromPrint_Load(object sender, EventArgs e)
        {
            DateTime fromDate = Convert.ToDateTime(fromToDate[0]);
            DateTime toDate = Convert.ToDateTime(fromToDate[1]);
            string DrName = "Dr. Hazrat Ali Khan. Technician, Pishawer. (RCCD) & MBBS Canada";
            OrderDetailBindingSource.DataSource = _list;
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("paraFromDate",fromDate.ToString("MM/dd/yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter("paraToDate",toDate.ToString("MM/dd/yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter("paraDrName",DrName),
                new Microsoft.Reporting.WinForms.ReportParameter("paraSyrupCount",_list.Where(m=>m.MedType==1).Count().ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("paraTabletCount",_list.Where(m=>m.MedType==3).Count().ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("paraInjCount",_list.Where(m=>m.MedType==2).Count().ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("paraOthersCount",_list.Where(m=>m.MedType==4).Count().ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("paraPatientsCount",_list.Select(m=>m.PID).Count().ToString())

            };
            this.reportViewer.LocalReport.SetParameters(p);
            reportViewer.LocalReport.DataSources.Clear();
            ReportDataSource datasource = new ReportDataSource("MedicineDs", _list);
            reportViewer.LocalReport.DataSources.Add(datasource);
            reportViewer.LocalReport.Refresh();

            this.reportViewer.RefreshReport();
        }
    }
}
