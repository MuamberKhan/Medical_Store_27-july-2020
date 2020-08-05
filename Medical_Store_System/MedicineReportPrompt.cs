using Medical_Store_System.ProjectReports;
using System;
using System.Windows.Forms;

namespace Medical_Store_System
{
    public partial class MedicineReportPrompt : Form
    {
       
        #region Singleton Pattern 
        protected static MedicineReportPrompt _Instance { get; set; }
        public MedicineReportPrompt()
        {
            InitializeComponent();
        }
        public static MedicineReportPrompt Instance
        {
            get
            {

                if (_Instance == null)
                    _Instance = new MedicineReportPrompt();

                return _Instance;
            }
        }
        #endregion
        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Close();
            InitializeSaleEstimateReport rptInit = new InitializeSaleEstimateReport(dateFrom.Value, dateTo.Value);
            rptInit.InitialiazeReport();

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportPrompt_Load(object sender, EventArgs e)
        {
            dateFrom.Text = DateTime.Today.AddMonths(-1).ToShortDateString();

        }
    }
}
