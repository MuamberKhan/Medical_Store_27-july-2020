using MSS_Reporting;
using System;
using System.Windows.Forms;
namespace Medical_Store_System
{
    public partial class ReportPrompt : Form
    {
        public ReportPrompt()
        {
            InitializeComponent();
        }

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
