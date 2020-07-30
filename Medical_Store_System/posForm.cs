using BusinessLogic;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Medical_Store_System
{
    public partial class posForm : Form
    {
        ProcessMedicine medicineProcess = new ProcessMedicine();

        string searchTerm = null;
       
        #region Singleton Pattern 
        protected static posForm _Instance { get; set; }
        public posForm(string searchTerm)
        {
            InitializeComponent();
            this.searchTerm = searchTerm;

        }
        public static posForm Instance(string searchTerm)
        {
           
                if (_Instance == null || _Instance.IsDisposed)
                    _Instance = new posForm(searchTerm);

                return _Instance;
        }
        #endregion

        private void posForm_Load(object sender, EventArgs e)
        {
            txtSearchMedicine.Text = searchTerm;
            lblStatus.Text = "Please wait while loading......";
            try
            {
                loadGridData(searchTerm,true);
                lblStatus.Text = "Loading Done";
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadGridData(txtSearchMedicine.Text,false);
        }
        private void loadGridData(string searchTerm,bool isFirstLoad)
        {
            gridViewMedicines.AutoGenerateColumns = false;
            try
            {
                if (isFirstLoad)
                {
                    var link = new DataGridViewLinkColumn();
                    link.DisplayIndex = 0;
                    link.DefaultCellStyle.NullValue = "Sale";
                    link.DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;
                    link.Width = 60;
                    link.ActiveLinkColor = Color.White;
                    link.LinkBehavior = LinkBehavior.AlwaysUnderline;
                    link.LinkColor = Color.Crimson;
                    link.VisitedLinkColor = Color.YellowGreen;

                    gridViewMedicines.Columns.Add(link);
                    gridViewMedicines.AllowUserToAddRows = false;
                }
                if (searchTerm!="")
                {
                    gridViewMedicines.DataSource = medicineProcess.SearchMedicine(searchTerm);
                       // context.Medicines.Where(m=>m.MedName.Contains(searchTerm)).ToList();

                }
                else
                {
                    gridViewMedicines.DataSource = medicineProcess.GetMedicines();
                        //context.Medicines.ToList();
                }


            }
            catch (Exception)
            {
            }
            finally
            {
                

            }
        }

        private void gridViewMedicines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblStatus.Text = "Please Wait.....";
            int MedID = Convert.ToInt32(gridViewMedicines[0, e.RowIndex].Value);
            var model = medicineProcess.getMedicineByID(MedID);
                //context.Medicines.Where(m => m.ID == MedID).First();

          
            medicineProcess.UpdateMedicine(model,false);

            this.Close();
            BillForm.Instance("", model.MedSellPrice.Value, DateTime.Now.ToString()).ShowDialog();
            

            lblStatus.Text = "Deducted Successfully";
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
    }
}
