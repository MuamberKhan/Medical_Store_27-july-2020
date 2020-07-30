using BusinessLogic;
using LocalDataBase;
using MSS_Process.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Medical_Store_System
{
    public partial class ViewPatientDetailsForm : Form
    {
        ProcessPatient processPatient = new ProcessPatient();
        public int PateintID { get; set; }
      
        #region Singleton Pattern 
        protected static ViewPatientDetailsForm _Instance { get; set; }
        public ViewPatientDetailsForm(int PateintID)
        {
            InitializeComponent();
            this.PateintID = PateintID;
        }
        public static ViewPatientDetailsForm Instance(int pateintID)
        {

            if (_Instance != null)
                _Instance.Dispose();
            return _Instance = new ViewPatientDetailsForm(pateintID);

        }
        #endregion

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Are you sure you want to exit the application?", "Warning", MessageBoxButtons.YesNo);
            if (message.ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void ViewPatientDetailsForm_Load(object sender, EventArgs e)
        {
            LoadPateint(this.PateintID,1);
        }
        //private void LoadPateint(int PateintID)
        //{

        //    try
        //    {
        //        var allPateints = context.Patients.Include(p => p.PateintRecords).Where(x => x.ID == pateintID).Single();
        //        count = allPateints.PateintRecords.Count();
        //        lblTotalCount.Text = "Total: " + count + " records";
        //        var result = allPateints.PateintRecords.Skip(pageNo.Value).Take(1).ToList();

        //        lblDated.Text = " (" + result.First().AppointmentDate.ToString() + ")";
        //        lblName.Text = allPateints.PatientName;
        //        lblAddress.Text = allPateints.PatientAddress;
        //        lblDiagnosis.Text = result.First().Diagnosis;
        //        lblTreatment.Text = result.First().Treatment;
        //        lblDescription.Text = result.First().Description;

        //        lstPrescribedMedicines.Items.Clear();
        //        foreach (var item in result.First().RecordsMedicines)
        //        {
        //            lstPrescribedMedicines.Items.Add(item.Medicine.MedName);
        //        }


        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {

        //    }
        //}
        private void LoadPateint(int pateintID, int pageNo, int pageSize=1)
        {
            
            try
            {
                var result=processPatient.GetPatientRecords(pateintID,pageNo,pageSize);
                var pateint = result.Item1.Select(r=>r.Patient).Single();
                var pateintRecord = result.Item1.First();

                if(pageNo > result.Item2)
                {
                    btnNext.Enabled = false;
                }
                pateintRecordCount = result.Item2;
                lblTotalCount.Text = "Total: " + pateintRecordCount + " records";
               
                lblDated.Text = " (" + pateintRecord.AppointmentDate.ToString() + ")";
                lblName.Text = pateint.PatientName;
                lblAddress.Text = pateint.PatientAddress;
                lblDiagnosis.Text = pateintRecord.Diagnosis;
                lblTreatment.Text = pateintRecord.Treatment;
                lblDescription.Text = pateintRecord.Description;

                lstPrescribedMedicines.Items.Clear();
                foreach (var item in pateintRecord.RecordsMedicines)
                {
                    //lstPrescribedMedicines.Items.Add(item.Medicine.MedName);
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
            finally
            {

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGoMedicines_Click(object sender, EventArgs e)
        {
            medicinesForm.Instance(null).Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            MainForm.Instance().Show();
            this.Hide();
        }

        private void btnBackPateints_Click(object sender, EventArgs e)
        {
            PatientForm.Instance.Show();
            this.Hide();
        }
        int pageNo = 1;
        private int pateintRecordCount;

        private void btnNext_Click(object sender, EventArgs e)
        {
            pageNo++;
            if (pageNo<=pateintRecordCount && pageNo>0)
            {
                LoadPateint(this.PateintID, pageNo, 1);
                
            }
            else
            {
                pageNo = 0;
            }
            
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
           
            if (pageNo <= pateintRecordCount && pageNo > 0)
            {
                LoadPateint(this.PateintID, pageNo, 1);
                pageNo--;
            }
            else
            {

                pageNo = pateintRecordCount;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
