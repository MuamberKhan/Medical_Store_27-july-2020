using LocalDataBase;
using System;
using System.Windows.Forms;

namespace Medical_Store_System
{
    public partial class BillForm : Form
    {
        MedicalStore_dbEntities context = new MedicalStore_dbEntities();
        decimal BillAmount = -1;
        string time = null;
      
        #region Singleton Pattern 
        protected static BillForm _Instance { get; set; }
        public BillForm(string Name, decimal BillAmount, string time)
        {
            InitializeComponent();
            this.Name = Name;
            this.BillAmount = BillAmount;
            this.time = time;

        }
        public static BillForm Instance(string Name, decimal BillAmount, string time)
        {


            if (_Instance == null)
                _Instance = new BillForm(Name, BillAmount, time);

            return _Instance;
        }
        #endregion
        private void billForm_Load(object sender, EventArgs e)
        {
            lblDated.Text += time;
            lblName.Text += Name;
            lblTotalAmount.Text += BillAmount.ToString();

            
        }

        private void BillForm_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == (char)Keys.Enter) //e.KeyChar == 13
            {
                
            }
        }
    }
}
