
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic;
using LocalDataBase;

namespace Medical_Store_System
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;
        private User LoggedInUser =new User();
        ProcessMedicine processMedicine = new ProcessMedicine();
        ProcessUser processUser = new ProcessUser();

        #region Singleton Pattern 
        protected static MainForm _Instance { get; set; }

       
        public MainForm(User user)
        {
            InitializeComponent();
            LoggedInUser = user;
        }
        public static MainForm Instance(User user=null)
        {


            if (_Instance == null || _Instance.IsDisposed)
                _Instance = new MainForm(user);

            return _Instance;
        }
        #endregion
        private void btnPOS_Click(object sender, EventArgs e)
        {
            txtSearchPOS.Enabled = false;
            lblStatus.Text = "Please While loading the data.";
            posForm.Instance(txtSearchPOS.Text).Show();
            txtSearchPOS.Enabled = true;
            lblStatus.Text = "Done!";
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
          
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void btnAvailableStock_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Please wait while loading";
            medicinesForm.Instance(null).Show();
           // myForm.MdiParent = this;
            //myForm.WindowState = FormWindowState.Normal;
            //myForm.Show();
            lblStatus.Text = "Loading Done!";
        }

        public async void mainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            if (LoggedInUser == null || string.IsNullOrWhiteSpace(LoggedInUser.Username))
            {
                logOutIconMenuItem.Visible = false;
                ChangePassIconMenuItem.Visible = false;

            }
            else
            {
                loginIconMenuItem.Visible = false;
                accountToolStripMenuItem.Text = "Welcome: " + LoggedInUser.Username;
            }


            tmrTime.Enabled = true;
            lnkLackingMed.Text = "Loading....";
            var lackingMedCount = await processMedicine.GetLackingMedicinesCountAsync();
            lnkLackingMed.Text = "Click here to view: " + "( " + lackingMedCount.ToString() + " )";

            var PendingBills =await processMedicine.GetPendingBillsCountAsync();

            lnkPendingBills.Text = "Loading....";
            lnkPendingBills.Text = "You have some pending bills:  " + "( " + PendingBills + " )";
        }
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text="Today: "+ DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text ="Date: "+ DateTime.Now.ToShortDateString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }


        private void btnMakeNewEntry_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Please wait while loading";
            var myForm = new PatientForm();
            // myForm.MdiParent = this;
            myForm.WindowState = FormWindowState.Normal;
            myForm.Show();
            lblStatus.Text = "Loading Done!";
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Are you sure you want to exit the application?", "Warning", MessageBoxButtons.YesNo);
            if (message.ToString() == "Yes")
            {
                Application.Exit();
            }
        }
        

        private void btnOpenCalc_Click(object sender, EventArgs e)
        {
           //rocess.Start(Calculater.Program.returnPath() + "\\Calculater.exe");

        }

        private void lnkPendingBills_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewPendingBillsDetailsForm.Instance().ShowDialog();
            MainForm.Instance().mainForm_Load(sender,e);
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult message = MessageBox.Show("Are you sure you want to exit the application?", "Warning", MessageBoxButtons.YesNo);
                if (message.ToString() == "Yes")
                {
                    processUser.LoggoutUser(LoggedInUser);
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                    return;
                }
            }
           
        }

        private void lnkReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MedicineReportPrompt.Instance.ShowDialog();
        }

        private void btnOpenCalc_MouseHover(object sender, EventArgs e)
        {
            lblStatus.Text = "Open Calculator";
        }

        private void btnOpenCalc_DragLeave(object sender, EventArgs e)
        {
            lblStatus.Text = "Status";
        }

        private void btnManageLogins_MouseLeave(object sender, EventArgs e)
        {
           lblStatus.Text = "Status";
        }

        private void btnManageLogins_MouseHover(object sender, EventArgs e)
        {  lblStatus.Text = "Manage your accounts, or create guest account.";
           
        }

        private void btnExitApp_MouseLeave(object sender, EventArgs e)
        {
            lblStatus.Text = "Status";
        }

        private void btnExitApp_MouseHover(object sender, EventArgs e)
        {
            lblStatus.Text = "Close the application.";
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            lblStatus.Text = "Add, Edit or Delete medicine records in the store.";
        }

        private void btnAvailableStock_MouseHover(object sender, EventArgs e)
        {
            lblStatus.Text = "Add, Edit or Delete medicine records in the store.";
        }

        private void btnAvailableStock_MouseLeave(object sender, EventArgs e)
        {
            lblStatus.Text = "Status";
        }

        private void btnGenerateReports_MouseLeave(object sender, EventArgs e)
        {
            lblStatus.Text = "Status";
        }

        private void btnGenerateReports_MouseHover(object sender, EventArgs e)
        {
            lblStatus.Text = "Generate Report Against Medicines.";
        }

        private void btnMakeNewEntry_MouseHover(object sender, EventArgs e)
        {
            lblStatus.Text = "Add, Edit or Delete patients records in the store.";
        }

        private void btnMakeNewEntry_MouseLeave(object sender, EventArgs e)
        {
            lblStatus.Text = "Status";
        }

        private void btnFindPatient_Click(object sender, EventArgs e)
        {
            ShwDtaildPatntsForm.Instance.Show();
        }

        private void btnFindPatient_MouseLeave(object sender, EventArgs e)
        {
            lblStatus.Text = "Status";
        }

        private void btnFindPatient_MouseMove(object sender, MouseEventArgs e)
        {
            lblStatus.Text = "Search a patient.";
        }

        private void txtSearchPOS_MouseLeave(object sender, EventArgs e)
        {
            lblStatus.Text = "Status";
        }

        private void btnPOS_MouseLeave(object sender, EventArgs e)
        {
            lblStatus.Text = "Status";
        }

        private void txtSearchPOS_MouseHover(object sender, EventArgs e)
        {
            lblStatus.Text = "Please provide some medicine name to bring onto the front.";
        }

        private void btnPOS_MouseHover(object sender, EventArgs e)
        {
            lblStatus.Text = "Press, to open (POS)Point Of Sale";
        }

        private void lnkLackingMed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LackingMedFrom.Instance.ShowDialog();
        }

        private void btnManageLogins_Click(object sender, EventArgs e)
        {
            if (LoggedInUser.Type == "Admin" || LoggedInUser.Type=="Administrator")
            {
               
                UsersForm.Instance.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sorry, you are not athorized to access this account.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

        }
        private void logOutIconMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                processUser.LoggoutUser(LoggedInUser);

                this.Dispose();
                LoginForm.Instance.ShowDialog();
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ChangePassIconMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(LoggedInUser);
            changePassword.ShowDialog();
        }
        
        private void accountToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            accountToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;

        }

        private void accountToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            accountToolStripMenuItem.ForeColor = Color.White;
        }

        private void btnViewDetMed_Click(object sender, EventArgs e)
        {
            ShwDtaildMdicinsForm shwDtaildMdicinsForm = new ShwDtaildMdicinsForm();
            shwDtaildMdicinsForm.Show();

        }

        private void lnkPatientReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PateintReportPrompt.Instance.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           


        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            fileToolStripMenuItem.BackColor = Color.White;
            fileToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;

        }

        private void fileToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.BackColor = SystemColors.MenuHighlight;
        }

        private void editToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            editToolStripMenuItem.ForeColor = Color.White;
            editToolStripMenuItem.BackColor = SystemColors.MenuHighlight;
        }

        private void toolsToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            toolsToolStripMenuItem.ForeColor = Color.White;
            toolsToolStripMenuItem.BackColor = SystemColors.MenuHighlight;
        }

        private void helpToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            helpToolStripMenuItem.ForeColor = Color.White;
            helpToolStripMenuItem.BackColor = SystemColors.MenuHighlight;
        }

        private void editToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            editToolStripMenuItem.BackColor = Color.White;
            editToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
        }

        private void toolsToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            toolsToolStripMenuItem.BackColor = Color.White;
            toolsToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
        }

        private void helpToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            helpToolStripMenuItem.BackColor = Color.White;
            helpToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMe.Instance.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            WarningForm warn = new WarningForm();
            warn.ShowDialog();

        }

        private void btnDoctorDetails_Click(object sender, EventArgs e)
        {
            WarningForm warn = new WarningForm();
            warn.ShowDialog();
        }
    }
}
