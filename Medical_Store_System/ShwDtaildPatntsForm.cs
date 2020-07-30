using BusinessLogic;
using Medical_Store_System.Models;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Medical_Store_System
{
    public partial class ShwDtaildPatntsForm : Form
    {
        #region Singleton Pattern 
        protected static ShwDtaildPatntsForm _Instance { get; set; }
        public ShwDtaildPatntsForm()
        {
            InitializeComponent();
        }
        public static ShwDtaildPatntsForm Instance
        {
            get
            {
                if (_Instance == null || _Instance.IsDisposed)
                    _Instance = new ShwDtaildPatntsForm();

                return _Instance;
            }
        }
        #endregion

        ProcessPatient processPatient = new ProcessPatient();
        private void ShwDtaildPatntsForm_Load(object sender, EventArgs e)
        {
            try
            {
                var result = processPatient.GetPatients().Item1.Select(x => new PateintDetailsModel
                {
                    ID = x.ID,
                    PatientName = x.PatientName,
                    PatientGender = processPatient.getPateintType(x.PatientType.Value),
                    PatientAddress = x.PatientAddress,
                    AppointmentDate = x.PateintRecords.FirstOrDefault().AppointmentDate,
                    PatientDiagnosis = x.PateintRecords.FirstOrDefault().Diagnosis,
                    PatientTreatment = x.PateintRecords.FirstOrDefault().Treatment,
                    PatientDescription = x.PateintRecords.FirstOrDefault().Description
                }).ToList();




                dataGridPatDetails.AutoGenerateColumns = false;
                dataGridPatDetails.DataSource = result;
                AddDetailsColumn();
                    
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AddDetailsColumn()
        {
            var button = new DataGridViewButtonColumn();
            {
                button.HeaderText = "Action";
                button.Text = "See Details";
                button.UseColumnTextForButtonValue = false;
                button.DefaultCellStyle.NullValue = "See Details";

                button.FlatStyle = FlatStyle.Flat;
                button.CellTemplate.Style.BackColor = SystemColors.MenuHighlight;
                button.CellTemplate.Style.ForeColor = Color.White;
                button.DisplayIndex = 6;
            }
            var button2 = new DataGridViewButtonColumn();
            {
                button2.HeaderText = "Action";
                //button2.Text = "See Bills";
                button2.DefaultCellStyle.NullValue = "See Bills";
                button.UseColumnTextForButtonValue = false;

                button2.FlatStyle = FlatStyle.Flat;
                button2.CellTemplate.Style.BackColor = SystemColors.MenuHighlight;
                button2.CellTemplate.Style.ForeColor = Color.White;
                button2.DisplayIndex = 5;
            }
            dataGridPatDetails.Columns.Add(button2);
            dataGridPatDetails.Columns.Add(button);
            dataGridPatDetails.AllowUserToAddRows = false;
        }

        private void dataGridPatDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var action = senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex;
                switch (action)
                {
                    case 5:
                        var ID = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].Value);
                        ViewPendingBillsDetailsForm.Instance(ID).ShowDialog();
                        break;
                    case 6:
                         ID = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].Value);
                        ViewPatientDetailsForm.Instance(ID).ShowDialog();
                        break;
                    default:
                        break;
                }
               
            }
        }
    }
}
