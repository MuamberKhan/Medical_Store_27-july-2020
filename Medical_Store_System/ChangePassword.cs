using LocalDataBase;
using System;
using System.Data;
using System.Windows.Forms;

namespace Medical_Store_System
{
    public partial class ChangePassword : Form
    {
        private readonly User user;
       
        #region Singleton Pattern 
        protected static ChangePassword _Instance { get; set; }
        public ChangePassword(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        public static ChangePassword Instance(User user)
        {


            if (_Instance == null)
                _Instance = new ChangePassword(user);

            return _Instance;
        }
        #endregion
        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            MedicalStore_dbEntities context = new MedicalStore_dbEntities();
            if (txtOldPassword.Text!=user.Password)
            {
                lblError.Visible = true;
                lblError.Text = "Old Password incorrect.";
            }
            if (txtPassword.Text != txtReEnterPass.Text)
            {
                lblError.Visible = true;
                lblError.Text = "Passwords not matched";
            }
            else
            {
                lblError.Visible = false;
                user.Password = txtPassword.Text;
                context.Entry(user).State =EntityState.Modified;
                context.SaveChanges();
                MessageBox.Show("Password is changed successfully.","Info",MessageBoxButtons.OK);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
