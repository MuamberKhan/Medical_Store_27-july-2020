using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogic;

namespace Medical_Store_System.UserControler
{
    public partial class PendingBillsDetails : UserControl
    {
        ProcessBills processBills = new ProcessBills();
        string billName;
        decimal BillAmount;
        DateTime time;
        private readonly int ID;

        public PendingBillsDetails()
        {
            InitializeComponent();

        }
        public PendingBillsDetails(int ID,string billName, decimal BillAmount,DateTime time)
        {
            InitializeComponent();
            this.billName = billName;
            this.BillAmount = BillAmount;
            this.time = time;
            this.ID = ID;

        }

        private void PendingBillsDetails_Load(object sender, EventArgs e)
        {
            lblName.Text += billName;
            lblBillAmount.Text += BillAmount.ToString();
            lblDated.Text += time.ToString();
        }

        private void btnPendingBillPaid_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            DialogResult result = MessageBox.Show("Is ("+"Mr.(s) "+billName+") paying the bill now?","Please Confrim!",MessageBoxButtons.YesNo,MessageBoxIcon.Hand);
            if (result.ToString()=="Yes")
            {
                processBills.BillPaied(ID);
                button.Text = "Cleared";
                button.BackColor = Color.White;
                button.ForeColor = SystemColors.MenuHighlight;
            }
           
        }
    }
}
