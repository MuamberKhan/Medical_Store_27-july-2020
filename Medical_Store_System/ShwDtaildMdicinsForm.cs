using BusinessLogic;
using Medical_Store_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Store_System
{
    public partial class ShwDtaildMdicinsForm : Form
    {
        ProcessMedicine processMedicine = new ProcessMedicine();
       
        #region Singleton Pattern 
        protected static ShwDtaildMdicinsForm _Instance { get; set; }
        public ShwDtaildMdicinsForm()
        {
            InitializeComponent();
        }
        public static ShwDtaildMdicinsForm Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ShwDtaildMdicinsForm();

                return _Instance;
            }
        }
        #endregion
        private void ShwDtaildMdicinsForm_Load(object sender, EventArgs e)
        {
            try
            {
                var result = processMedicine.GetAllMedicines().Select(x => new MedicineDetailsModel
                {
                    ID = x.ID,
                    IsLacking = x.IsLacking == true ? "Yes" : "No",
                    MedDescription = x.MedDescription,
                    MedName = x.MedName,
                    MedPurchasePrice = x.MedPurchasePrice.Value,
                    MedSellPrice = x.MedSellPrice.Value,
                    MedStatus = "Not set",
                    Quantity = x.Quantity,
                    MedType = processMedicine.getMedineType(x.MedType.Value)
                }).ToList();

                dataGridMedDetailed.AutoGenerateColumns = false;
                dataGridMedDetailed.DataSource = result;
                AddLinkColumn();

            }
            catch (Exception ex)
            {

                lblStatus.Text = "Error: " + ex.Message;
            }

        }
        private void AddLinkColumn()
        {
            for (int i = 0; i < 3; i++)
            {
                DataGridViewLinkColumn link = new DataGridViewLinkColumn();

                link.UseColumnTextForLinkValue = true;
                link.HeaderText = "Action";
               
                link.DataPropertyName = null;
                link.ActiveLinkColor = Color.White;
                link.LinkBehavior = LinkBehavior.SystemDefault;
                link.TrackVisitedState = true;
                link.VisitedLinkColor = Color.LightGray;
                link.DisplayIndex = 9 + i;
                if (i==0)
                {
                    link.DefaultCellStyle.NullValue = "New";
                    link.LinkColor = SystemColors.MenuHighlight;
                    link.Name = "Edit";
                }
                if (i == 1)
                {
                    link.DefaultCellStyle.NullValue = "Edit";
                    link.LinkColor = SystemColors.MenuHighlight;
                    link.Name = "Update";
                }
                if (i == 2)
                {
                    link.DefaultCellStyle.NullValue = "Delete";
                    link.LinkColor = Color.Red;
                    link.Name = "Delete";
                }

                dataGridMedDetailed.Columns.Add(link);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {this.Close();
            MainForm.Instance().Show();
            
        }

        private void dataGridMedDetailed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
            {
                var action = senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex;
                var column=senderGrid.Columns[e.ColumnIndex] as DataGridViewLinkColumn;
               var isVisited= column.Selected? false: true;
                if (isVisited)
                {
                    switch (action)
                    {
                        case 9:
                            int ID = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].Value);
                            medicinesForm.Instance(null).Show();
                            break;
                        case 10:
                            ID = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].Value);
                            medicinesForm.Instance(ID).Show();
                            break;
                        case 11:
                            ID = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].Value);

                            DialogResult confrim = MessageBox.Show("Do you really want to delete this medicine parmanantly, the deletion operation cannot be undone", "Please confrim your action!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                            if (confrim == DialogResult.Yes)
                            {
                                processMedicine.DeleteMedicine(ID);

                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
