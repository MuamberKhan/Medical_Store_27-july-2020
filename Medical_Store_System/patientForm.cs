using BusinessLogic;
using LocalDataBase;
using Medical_Store_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Medical_Store_System
{
    public partial class PatientForm : Form
    {
        ProcessPatient processPatient = new ProcessPatient();
        ProcessMedicine processMedicine = new ProcessMedicine();
        List<Medicine> medicines = null;
        private decimal billAmount = 0;
        private readonly string[] patientNames;

        #region Singleton Pattern 
        protected static PatientForm _Instance { get; set; }
        public PatientForm()
        {
            InitializeComponent();
            this.patientNames = processPatient.GetPateintNames();
            medicines = processMedicine.GetMedicines();

        }
        public static PatientForm Instance
        {
            get
            {

                if (_Instance == null)
                {
                    _Instance = new PatientForm();
                }

                return _Instance;
            }
        }
        #endregion

        private void patientForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Loading......";
            cmboBxPatType.SelectedIndex = 0;
            try
            {
                //Appending all the patient names to the textbox
                txtPatName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtPatName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtPatName.AutoCompleteCustomSource.AddRange(patientNames);
                //
                lstAllMedicines.DataSource = medicines;
                lstAllMedicines.DisplayMember = "MedName";
                lstAllMedicines.ValueMember = "ID";
                loadGridData();
                lblStatus.Text = "Loading Done";
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void txtSearchInListBox_TextChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "Working on....";
            lstAllMedicines.DataSource = processMedicine.SearchMedicine(txtSearchInListBox.Text);
            lstAllMedicines.DisplayMember = "MedName";
            lstAllMedicines.ValueMember = "ID";
            lblStatus.Text = "Done !";
        }
        private void lstAllMedicines_DoubleClick(object sender, EventArgs e)
        {

            lblStatus.Text = "Medicines has being added to the selection....";
            int id = Convert.ToInt32(lstAllMedicines.SelectedValue);
            var selectedMedicine = processMedicine.getMedicineByID(id);

            lstSelectedMedicines.Items.Add(selectedMedicine.MedName);
            lstSelectedMedicines.DisplayMember = selectedMedicine.MedName;
            lstSelectedMedicines.ValueMember = selectedMedicine.ID.ToString();

            lblStatus.Text = "Medicines has added to selection";
        }
        private void txtSearchInListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) //e.KeyChar == 13
            {
                lstAllMedicines_DoubleClick(sender, e);
            }

        }
        private void btnSavePatient_Click(object sender, EventArgs e)
        {
            //Check Validation
            Control control = CheckValidity();
            if (control != null)
            {
                control.Focus();
                control.BackColor = Color.LightGray;
                lblStatus.Text = "Some fields are not filled please view them carefully.";
                return;
            }

            #region Filter the selected medicines and assign to the pateint

            //Getting the Prescribed medicinese from the list 
            List<Medicine> PateintSelectedMedicine = new List<Medicine>();

            foreach (var item in lstSelectedMedicines.Items)
            {
                Medicine medicine = new Medicine();
                medicine = medicines.Where(m => m.MedName == item.ToString()).First();

                billAmount = Convert.ToDecimal(billAmount + medicine.MedSellPrice);

                processMedicine.UpdateMedicine(medicine,true);
                //adding to the final list of pateint
                PateintSelectedMedicine.Add(medicine);
            }
            #endregion

            try
            {
                #region Save New Records
                var commandButton = sender as Button;
                if (commandButton.Text == "Save")
                {
                    //Saving the data into the database.
                    LocalDataBase.PateintRecord pateintRecord = new LocalDataBase.PateintRecord();
                    pateintRecord.Patient = new Patient();

                    //Getting the data for the Pateint 
                    pateintRecord.Patient.PatientName = txtPatName.Text;
                    //Getting the Enum value for the pateint type
                    pateintRecord.Patient.PatientType = processPatient.getPateintType(cmboBxPatType.Text);
                    pateintRecord.Patient.PatientAddress = txtPatResid.Text;
                    pateintRecord.Patient.FatherName = txtFatherName.Text;

                    // getting the data for the Pateint record 
                    pateintRecord.AppointmentDate = datePickerAppointment.Value;
                    pateintRecord.Description = txtPatDescription.Text;
                    pateintRecord.Diagnosis = txtPatDiagnosis.Text;
                    pateintRecord.Treatment = txtPatTreatment.Text;


                    // storing the selected medicines in the object
                    pateintRecord.RecordsMedicines = new List<RecordsMedicine>();


                    var medicinesIDs = PateintSelectedMedicine.Select(x => x.ID).ToList();
                    //adding medicines to the model object
                    foreach (var item in medicinesIDs)
                    {
                        pateintRecord.RecordsMedicines.Add(new RecordsMedicine() { MedicineID = item });
                    }
                    int SavedPatientID = processPatient.SavePatient(pateintRecord);
                    lblStatus.Text = "Data saved successfullly!";
                    generateBill(SavedPatientID, PateintSelectedMedicine.Select(i => i.ID).ToArray());
                }
                else if(commandButton.Text == "Update")
                {
                    //Updating the data into the database.
                    LocalDataBase.PateintRecord pateintRecord = new LocalDataBase.PateintRecord();

                    //Getting the data for the Pateint 
                    int pateintID = int.Parse(txtHiddenID.Text);
                   
                    // getting the data for the Pateint record 
                    pateintRecord.AppointmentDate = datePickerAppointment.Value;
                    pateintRecord.Description = txtPatDescription.Text;
                    pateintRecord.Diagnosis = txtPatDiagnosis.Text;
                    pateintRecord.Treatment = txtPatTreatment.Text;


                    // storing the selected medicines in the object
                    pateintRecord.RecordsMedicines = new List<RecordsMedicine>();


                    var medicinesIDs = PateintSelectedMedicine.Select(x => x.ID).ToList();
                    //adding medicines to the model object
                    foreach (var item in medicinesIDs)
                    {
                        pateintRecord.RecordsMedicines.Add(new RecordsMedicine() { MedicineID = item });
                    }
                    processPatient.AddRecordToPatient(pateintID,pateintRecord);
                    lblStatus.Text = "Data saved successfullly!";
                    generateBill(pateintID, PateintSelectedMedicine.Select(i => i.ID).ToArray());
                }

                loadGridData();
                #endregion
                clearFields();
                lblStatus.Text = "Record saved !";
            }
          
            catch (Exception ex)
            {

                lblStatus.Text = "Error: "+ex.Message;
            }

        }
        private void clearFields()
        {
            txtPatTreatment.Clear();
            txtFatherName.Clear();
            txtPatName.Clear();
            txtPatResid.Clear();
            txtPatTreatment.Clear();
            txtPatDiagnosis.Clear();
            txtPatDescription.Clear();
            cmboBxPatType.SelectedIndex = 1;
            btnSavePatient.Text = "Save";             
            lstSelectedMedicines.Items.Clear();
        }
        /// <summary>
        /// Function to check the validations of the control
        /// </summary>
        /// <returns>control as object</returns>
        private Control CheckValidity()
        {
            if (string.IsNullOrEmpty(txtPatName.Text) || txtPatName.Text.Length<=5)
            {
                return txtPatName;
            }
            if (string.IsNullOrEmpty(txtFatherName.Text) || txtFatherName.Text.Length <= 5)
                return txtFatherName;
            if (string.IsNullOrEmpty(txtPatDiagnosis.Text))
                return txtPatDiagnosis;
           
            if (string.IsNullOrEmpty(txtPatDiagnosis.Text))
                return txtPatDiagnosis;
            if (string.IsNullOrEmpty(txtPatTreatment.Text))
                return txtPatTreatment;
            if (string.IsNullOrEmpty(txtPatResid.Text) || txtPatResid.Text.Length <= 10)
                return txtPatResid;
            if (string.IsNullOrEmpty(txtPatTreatment.Text))
                return txtPatTreatment;

            if (string.IsNullOrEmpty(cmboBxPatType.Text) )
            {
                return cmboBxPatType;
            }
            if (lstSelectedMedicines.Items.Count <= 0)
                return lstSelectedMedicines;
            else return null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        private void dataGridPatients_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblStatus.Text = "Loading form for details";
                int PatID = Convert.ToInt32(dataGridPatients[0, e.RowIndex].Value);
                
                ViewPatientDetailsForm.Instance(PatID).ShowDialog();
                lblStatus.Text = "Loading Completed";
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Are you sure you want to exit the application?", "Warning", MessageBoxButtons.YesNo);
            if (message.ToString() == "Yes")
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// Function to generate bill again the current pateint.
        /// Also saves the selected medicines against this bill.
        /// </summary>
        /// <param name="Curent Patient ID"></param>
        /// <param name="Array of Medicines IDs"></param>
        private void generateBill(int savedPatientID,int[] medIDs)
        {
            var bill = new Bill();

            bill.BillAmount = this.billAmount;
            bill.BillDate = datePickerAppointment.Value;
            bill.PatientID = savedPatientID;

            var billform = new BillForm(txtPatName.Text, billAmount, datePickerAppointment.Value.ToString());
            if (billform.ShowDialog() == DialogResult.Yes)
            {
                bill.BillStatus = true;
            }
            else
            {
                bill.BillStatus = false;
            }

            int savedBillID = processPatient.SaveBill(bill);

            //Save bill-medicines data.
            BillMedicine billMedicine;  
            foreach (var item in medIDs)
            {
                billMedicine = new BillMedicine() { BilIID = savedBillID, MedicineID = item };
                processPatient.BillToMedicines(billMedicine);
                
            }
        }


        private void loadGridData()
        {
            try
            {
                dataGridPatients.AutoGenerateColumns = false;

                var DataBasePatients =  processPatient.GetPatients().Item1.OrderByDescending(p=>p.ID);

                List<PateintDetailsModel> listOfPatients = new List<PateintDetailsModel>();
                foreach (var item in DataBasePatients)
                {
                    PateintDetailsModel SinglePatient = new PateintDetailsModel()
                    {
                        ID = item.ID,
                        PatientName = item.PatientName,
                        PatientAddress = item.PatientAddress,
                        PatientDescription = item.PateintRecords.First().Description,
                        PatientDiagnosis = item.PateintRecords.First().Diagnosis,
                        PatientTreatment = item.PateintRecords.First().Treatment,
                        AppointmentDate = item.PateintRecords.First().AppointmentDate

                    };
                    // Getting gender
                   
                    SinglePatient.PatientGender =processPatient.getPateintType(item.PatientType.Value);

                    listOfPatients.Add(SinglePatient);
                }

                dataGridPatients.DataSource = listOfPatients;

            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
            }


        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.Instance().Show();
           
        }

        private void btnGoPateints_Click(object sender, EventArgs e)
        {
            this.Hide();
            medicinesForm.Instance(null).Show();
           
        }


        private void lstSelectedMedicines_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Delete) || e.KeyCode == Keys.Back)
            {
                if (lstSelectedMedicines.Items.Count >= 1)
                {
                    int index = lstSelectedMedicines.SelectedIndex >= 0 ? lstSelectedMedicines.SelectedIndex : 0;
                    lstSelectedMedicines.Items.RemoveAt(index);
                }
            }
        }

        private void PatientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.Instance().mainForm_Load(sender,e);
        }
        
        private void txtPatName_LostFocus(object sender, EventArgs e)
        {
            if (txtPatName.Text.Length > 5)
            {
                var existingName = patientNames.Where(n => n.ToLower() == txtPatName.Text.ToLower()).SingleOrDefault();

                if (!string.IsNullOrEmpty(existingName))
                {
                    var message = @"A patient with this name already exists, Do you want to update his/her record";
                    var tittle = "Please confirm!";
                    var icon = MessageBoxIcon.Warning;
                    var buttons = MessageBoxButtons.YesNo;
                    var dialogResult = MessageBox.Show(message, tittle, buttons, icon, MessageBoxDefaultButton.Button1);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //load the existing pateint against the name;
                        btnSavePatient.Text = "Update";
                        var existingPateint = processPatient.GetPatients(existingName).Item2 as Patient;
                        txtHiddenID.Text = existingPateint.ID.ToString();
                        txtPatName.Text = existingPateint.PatientName;
                        txtFatherName.Text = existingPateint.FatherName;
                        txtPatResid.Text = existingPateint.PatientAddress;

                    }
                }
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

