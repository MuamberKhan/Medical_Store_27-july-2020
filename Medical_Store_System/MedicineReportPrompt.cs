using System;
using System.Windows.Forms;
using MSS_Reporting;

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
            RpMedicineInit rptInit = new RpMedicineInit(dateFrom.Value,dateTo.Value);
            rptInit.InitialiazeReport();
            this.Hide();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ReportPrompt_Load(object sender, EventArgs e)
        {
            dateFrom.Text = DateTime.Today.AddMonths(-1).ToShortDateString();

        }
    }
}
