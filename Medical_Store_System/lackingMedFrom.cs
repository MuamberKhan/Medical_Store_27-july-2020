using BusinessLogic;
using System;
using System.Windows.Forms;

namespace Medical_Store_System
{
    public partial class LackingMedFrom : Form
    {
        ProcessMedicine medicineProcess = new ProcessMedicine();

        #region Singleton Pattern 
        protected static LackingMedFrom _Instance { get; set; }
        public LackingMedFrom()
        {
            InitializeComponent();
        }
        public static LackingMedFrom Instance
        {

            get
            {
                if (_Instance == null)
                    _Instance = new LackingMedFrom();

                return _Instance;
            }
        }
        #endregion
        private void lackingMedFrom_Load(object sender, EventArgs e)
        {
           
            lblStatus.Text = "Please wait while loading......";
            try
            {
                loadGridData(null);
                lblStatus.Text = "Loading Done";
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void loadGridData(string searchTerm)
        {
            gridViewLackMedicines.AutoGenerateColumns = false;
            try
            {
                if (searchTerm != "")
                {
                    gridViewLackMedicines.DataSource = medicineProcess.getLackingMedicines(searchTerm);
                        //context.Medicines.Where(m => m.IsLacking!=false).ToList();

                }
                else
                {
                    gridViewLackMedicines.DataSource = medicineProcess.getLackingMedicines();
                    //context.Medicines.Where(m => m.IsLacking!=false).ToList();
                }


            }
            catch (Exception)
            {
            } 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadGridData(txtSearchMedicine.Text);
        }
    }
}
