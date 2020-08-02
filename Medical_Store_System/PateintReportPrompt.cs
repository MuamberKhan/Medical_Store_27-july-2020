using BusinessLogic;
using MSS_Reporting;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Medical_Store_System
{
    public partial class PateintReportPrompt : Form
    {
        ProcessPatient processPatient = new ProcessPatient();

       
        #region Singleton Pattern 
        protected static PateintReportPrompt _Instance { get; set; }
        public PateintReportPrompt()
        {
            InitializeComponent();
        }
        public static PateintReportPrompt Instance
        {
            get
            {

                if (_Instance == null)
                    _Instance = new PateintReportPrompt();

                return _Instance;
            }
        }
        #endregion
        private void PateintReportPrompt_Load(object sender, EventArgs e)
        {
            string[] IDs = processPatient.getPateintIDs();
            txtPateintID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtPateintID.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtPateintID.AutoCompleteCustomSource.AddRange(IDs);

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
           
            if (txtPateintID.Text!=null && txtPateintID.Text.Count()>=1&&txtPatientName.Text!=null)
            {
                try
                {
                    int PateintID = Convert.ToInt16(txtPateintID.Text);
                  var  patientData = processPatient.getPateintByID(PateintID);

                    DialogResult dResult = MessageBox.Show("Do you want to Edit details for the this report, for better look?", "Please Wait >>>>", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (dResult.ToString() == "No")
                    {
                        btnYes.Text = "Wait...";
                        RptPateintInit rptPateintInit = new RptPateintInit(PateintID);
                        rptPateintInit.InitialiazeReport();
                    }
                    else
                    {
                        PatientEditForm.Instance(patientData).Show();
                    }
                }
                catch (Exception ex)
                {
                    return;
                }
            }
            else
            {
            }

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtPateintID_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
