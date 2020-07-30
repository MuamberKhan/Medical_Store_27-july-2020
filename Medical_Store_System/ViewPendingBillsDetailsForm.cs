using LocalDataBase;
using Medical_Store_System.UserControler;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Medical_Store_System
{
    public partial class ViewPendingBillsDetailsForm : Form
    {
        MedicalStore_dbEntities context = new MedicalStore_dbEntities();
        public int PateintID { get; set; }

        #region Singleton Pattern 
        protected static ViewPendingBillsDetailsForm _Instance { get; set; }
        public ViewPendingBillsDetailsForm(int PateintID)
        {
            InitializeComponent();
            this.PateintID = PateintID;
        }
        /// <summary>
        /// The Defual Value for the contruct is -1
        /// </summary>
        /// <param name="pateintID">Optional</param>
        /// <returns>Object of the class</returns>
        public static ViewPendingBillsDetailsForm Instance(int pateintID = -1)
        {

            if (_Instance == null || _Instance.IsDisposed)
                _Instance = new ViewPendingBillsDetailsForm(pateintID);
            _Instance.PateintID = pateintID;
            return _Instance;

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
            if (this.PateintID >= 1)
            {
                LoadPateint(this.PateintID);
            }
            else
            {
                LoadPateint();
            }

        }

        private void LoadPateint()
        {
            try
            {
                var result = context.Bills.Where(p => p.BillStatus != true).ToList();

                if (result!=null)
                {
                    lblNoPendingBills.Visible = false;
                    int y = 7;
                    int x = 0;
                    pnlListArea.Controls.Clear();
                    foreach (var item in result)
                    {
                        PendingBillsDetails userControl = new PendingBillsDetails(item.ID, item.Patient.PatientName, item.BillAmount, item.BillDate);

                        userControl.Dock = System.Windows.Forms.DockStyle.Top;
                        userControl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        userControl.Location = new System.Drawing.Point(0, y);
                        userControl.Margin = new System.Windows.Forms.Padding(4);
                        userControl.Name = "controlPendingBillsDetails" + x;
                        //userControl.Size = new System.Drawing.Size(540, 79);
                        userControl.TabIndex = 0;
                        userControl.BringToFront();
                        y += 79;
                        x++;
                        this.pnlListArea.Controls.Add(userControl);

                        userControl.Visible = true;

                    }

                }
                else
                {
                    lblNoPendingBills.Visible = true;
                }



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LoadPateint(int pateintID)
        {
            try
            {
                var result = context.Patients.Include(p => p.Bills).Where(p => p.ID == pateintID).FirstOrDefault();

                if (result.Bills.Count >= 1)
                {
                    int y = 7;
                    int x = 0;
                    pnlListArea.Controls.Clear();
                    foreach (var item in result.Bills)
                    {
                        PendingBillsDetails userControl = new PendingBillsDetails(item.ID, item.Patient.PatientName, item.BillAmount, item.BillDate);

                        userControl.Dock = System.Windows.Forms.DockStyle.Top;
                        userControl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        userControl.Location = new System.Drawing.Point(0, y);
                        userControl.Margin = new System.Windows.Forms.Padding(4);
                        userControl.Name = "controlPendingBillsDetails" + x;
                        //userControl.Size = new System.Drawing.Size(540, 79);
                        userControl.TabIndex = 0;
                        userControl.BringToFront();
                        y += 79;
                        x++;
                        this.pnlListArea.Controls.Add(userControl);

                        userControl.Visible = true;

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGoMedicines_Click(object sender, EventArgs e)
        {
            this.Close();
            medicinesForm.Instance(null).Show();
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
            this.Close();
        }
    }
}
