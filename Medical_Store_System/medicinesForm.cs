using BusinessLogic;
using LocalDataBase;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Medical_Store_System
{
    public partial class medicinesForm : Form
    {
        ProcessMedicine medicineProcess = new ProcessMedicine();



        #region Singleton Pattern 
        protected static medicinesForm _Instance { get; set; }
        public medicinesForm(int? ID)
        {
            InitializeComponent();
            if (ID!=null)
            {
                EditOperation(ID.Value);
            }

        }
        public static medicinesForm Instance(int? ID)
        {
            if (_Instance == null || _Instance.IsDisposed)
                    _Instance = new medicinesForm(ID);

                return _Instance;
            
        }
        #endregion

        private void btnSaveMedicine_Click(object sender, EventArgs e)
        {
            Button button = sender as Button; ;
            Control control = CheckValidity();
            if (control != null)
            {
                control.Focus();
                control.BackColor = Color.LightGray;
                lblStatus.Text = "Some fields are not filled please view them carefully.";
                return;
            }


            if (button.Text=="Save")
            {
                lblStatus.Text = "Please wait saving process under goes.......";
                
                Medicine model = new Medicine();

                model.MedName = txtMedName.Text;
                model.MedPurchasePrice = Convert.ToDecimal(txtMedOrigPrice.Text.Substring(0, txtMedOrigPrice.Text.IndexOf('p')));
                model.MedSellPrice = Convert.ToDecimal(txtMedSellPrice.Text);
                model.MedDescription = txtDescription.Text;
                model.Quantity = Convert.ToInt32(numUpDwnQuantity.Value);        
                
                try
                {
                    medicineProcess.AddMedicine(model, cmboBxMedType.Text);
                    lblStatus.Text = "Saved Successfully";
                    clearFields();
                    loadGridData();
                }
                catch (Exception ex)
                {

                    lblStatus.Text = "Error: "+ex.Message;
                }
            }
            else if (button.Text=="Update")
            {
                lblStatus.Text = "Please wait updating process under goes.......";
               
                int ID = Convert.ToInt32(txtHiddenID.Text);

                Medicine model= medicineProcess.getMedicineByID(ID);


                model.MedName = txtMedName.Text;
                model.MedPurchasePrice = Convert.ToDecimal(txtMedOrigPrice.Text.Substring(0, txtMedOrigPrice.Text.IndexOf('p')));
                model.MedSellPrice = Convert.ToDecimal(txtMedSellPrice.Text);
                model.MedDescription = txtDescription.Text;
                model.Quantity = Convert.ToInt32(numUpDwnQuantity.Value);

                try
                {
                    medicineProcess.UpdateMedicine(model,false, cmboBxMedType.Text);
                    lblStatus.Text = "Updated Successfully";
                    loadGridData();
                    clearFields();

                }
                catch (Exception)
                {

                    lblStatus.Text = "Something went wrong, try again";
                }
            }
            
        }

        private void medicinesForm_Load(object sender, EventArgs e)
        {

            cmboBxMedType.SelectedIndex = 1;
            lblStatus.Text = "Please wait while loading......";
            try
            {
                loadGridData();
                lblStatus.Text = "Loading Done";
            }
            catch (Exception)
            {

                throw;
            }
               
        }

        private void loadGridData()
        {
            try
            {
                gridViewMedicines.AutoGenerateColumns = false;
                gridViewMedicines.DataSource = medicineProcess.GetMedicines();

            }
            catch (Exception ex)
            {
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = "PLease wait while searching";
                string medName = txtSearchMedicine.Text;
                string medTypeString = comboBoxMedSearch.Text;
               
               gridViewMedicines.DataSource =medicineProcess.SearchMedicine(medName, medTypeString);            
              lblStatus.Text = "Search completed";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
            }
        }

        private void gridViewMedicines_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int MedID = Convert.ToInt32(gridViewMedicines[0, e.RowIndex].Value);

            EditOperation(MedID);
        }

        private void EditOperation(int ID)
        {
            try
            {
                btnSaveMedicine.Text = "Update";
                lblStatus.Text = "PLease wait while the data is being processed for Edit Operation";
                var result = medicineProcess.getMedicineByID(ID);

                ///Setting values to the fields
                txtHiddenID.Text = result.ID.ToString();
                txtMedName.Text = result.MedName;
                txtMedOrigPrice.Text = result.MedPurchasePrice.ToString();
                txtMedSellPrice.Text = result.MedSellPrice.ToString();
                txtDescription.Text = result.MedDescription;
                numUpDwnQuantity.Value = Convert.ToDecimal(result.Quantity);

                cmboBxMedType.Text = medicineProcess.getMedineType(result.MedType.Value);
                lblStatus.Text = "Medicine Loaded";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
            }
        }

        private void btnCancelMedicine_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            txtDescription.Clear();
            txtHiddenID.Clear();
            txtMedName.Clear();
            txtMedOrigPrice.Clear();
            txtMedSellPrice.Clear();
            numUpDwnQuantity.Value = 0;
            cmboBxMedType.Text = "";
            btnSaveMedicine.Text = "Save";
        }
        private Control CheckValidity()
        {
            if (string.IsNullOrEmpty(txtMedName.Text))
                return txtMedName;
            if (string.IsNullOrEmpty(txtMedOrigPrice.Text))
                return txtMedOrigPrice;
            if(string.IsNullOrEmpty(txtMedSellPrice.Text))
                return txtMedSellPrice;
            if (Convert.ToInt32(numUpDwnQuantity.Value)<1)
            {
                return numUpDwnQuantity;
            }
            if (string.IsNullOrEmpty(cmboBxMedType.Text))
            {
                return cmboBxMedType;
            }
            else return null;
        }
        private void btnExitApp_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Are you sure you want to exit the application?", "Warning", MessageBoxButtons.YesNo);
            if (message.ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void txtMedName_MouseLeave(object sender, EventArgs e)
        {
            if (btnSaveMedicine.Text == "Save")
            {
                lblStatus.Text = "Please wait, while the medicine is being confrimed";
                var medicine = medicineProcess.getMedicineByName(txtMedName.Text);
                if (medicine != null)
                {
                    lblStatus.Text = "Matching medicine found!";
                    DialogResult dResult = MessageBox.Show("You already have this medicine in the stock, do you want to edit ?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dResult.ToString() == "Yes")
                    {
                        var result = medicineProcess.getMedicineByID(medicine.ID);
                        //Get Medicine Type
                        cmboBxMedType.Text = medicineProcess.getMedineType(result.ID);

                        btnSaveMedicine.Text = "Update";

                    }
                }
                lblStatus.Text = "Confirmation Done!";
            }
            else
            {
                return;
            }

        }

        private void txtSearchMedicine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearchMedicine.Text == "")
            {
                txtSearchMedicine.BackColor = Color.LightGray;
                return;
            }
            if (e.KeyChar == (char)Keys.Enter) //e.KeyChar == 13
            {
                btnSearch_Click(sender, e);
            }
        }
        
        private void btnGoPatients_Click(object sender, EventArgs e)
        {
           
            PatientForm.Instance.Show();
            this.Hide();
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            MainForm.Instance().Show();
            this.Hide();

        }

        private void btnShowPOS_Click(object sender, EventArgs e)
        {
            posForm objPOS = new posForm(null);
            objPOS.ShowDialog();
            this.Hide();
        }

        private void cmboBxMedType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get Medicine Type
            int medType = medicineProcess.getMedineType(cmboBxMedType.Text);

            switch (medType)
            {
                case 1:
                    lblUnit.Text = "Bottles";
                    break;
                case 2:
                    lblUnit.Text = "Inj.";
                    break;
                case 3:
                    lblUnit.Text = "Strips";
                    break;
                case 4:
                    lblUnit.Text = "Drips";
                    break;
                case 5:
                    lblUnit.Text = "Package";
                    break;
                default:
                    return;
            }
        }
        

        private void txtMedSellPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDiscount.Text != null && txtMedSellPrice.Text != null)
                {
                    var Discount = Convert.ToDecimal(txtDiscount.Text);
                    var MedSellPrice = Convert.ToDecimal(txtMedSellPrice.Text);
                    var calculatedPrice = ((Discount / 100) * MedSellPrice);

                    txtMedOrigPrice.Text = (MedSellPrice - calculatedPrice).ToString() + " per " + lblUnit.Text;
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {

                lblStatus.Text = "Error: " + ex.Message;
            }
        }

        private void medicinesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.Instance().Refresh();
        }
    }
}
