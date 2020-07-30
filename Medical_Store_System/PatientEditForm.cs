using BusinessLogic;
using LocalDataBase;
using MSS_Reporting;
using System;
using System.Windows.Forms;

namespace Medical_Store_System
{
    public partial class PatientEditForm : Form
    {
        private readonly Patient patient;
        ProcessPatient patientProcess = new ProcessPatient();


        #region Singleton Pattern 
        protected static PatientEditForm _Instance { get; set; }
        public PatientEditForm(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
        }
        public static PatientEditForm Instance(Patient patient)
        {

           
                if (_Instance == null || _Instance.IsDisposed)
                    _Instance = new PatientEditForm(patient);

                return _Instance;
        }
        #endregion
        private void PatientEditForm_Load(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = "Loading......";
                //If it is an edit request
                txtPatName.Text = patient.PatientName;
                txtHiddenID.Text = patient.ID.ToString();
               // datePickerAppointment.Value = patient.AppointmentDate.Value;
                cmboBxPatType.Text = patientProcess.getPateintType(patient.PatientType.Value);
                txtPatResid.Text = patient.PatientAddress;
                //txtPatTreatment.Text = patient.PatientTreatment;
                //txtPatDiagnosis.Text = patient.PatientDiagnosis;
                //txtPatDescription.Text = patient.PatientDescription;

                lstSelectedMedicines.DisplayMember = "MedName";
                lstSelectedMedicines.ValueMember = "ID";
                //foreach (var item in patient.PatientMedicines)
                //{
                //    lstSelectedMedicines.Items.Add(item.Medicine.MedName);
                //}
               
                lblStatus.Text = "Done";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnUpdateForPrint_Click(object sender, EventArgs e)
        {
               
            

            Patient objPateint = new Patient();

            //Getting the data from the Pateint form
            objPateint.ID = Convert.ToInt16(txtHiddenID.Text);
            objPateint.PatientName = txtPatName.Text;
            objPateint.PatientAddress = txtPatResid.Text;
            //objPateint.PatientDescription = txtPatTreatment.Text;
            //objPateint.AppointmentDate = datePickerAppointment.Value;
            //objPateint.PatientDiagnosis = txtPatDiagnosis.Text;
            //objPateint.PatientTreatment = txtPatTreatment.Text;


            //Getting the Enum value for the pateint type
            //Get Medicine Type

            objPateint.PatientType = patientProcess.getPateintType(cmboBxPatType.Text);

            //saving pateint data 

            try
            {
                //update pateint   
                patientProcess.UpdatePatient(objPateint);
                lblStatus.Text = "Data updated successfullly!";
                btnUpdatePatient.Text = "Print";

                btnUpdatePatient.Text = "Preparing for print...";
                RptPateintInit rptPateintInit = new RptPateintInit(Convert.ToInt16(txtHiddenID.Text));
                rptPateintInit.InitialiazeReport();
                this.Close();
            }
            catch (Exception ex)
            {

                lblStatus.Text = "Error:"+ex.Message;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
