using BusinessLogic;
using LocalDataBase;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Medical_Store_System
{
    public partial class LoginForm : Form
    {
        ProcessUser processUser = new ProcessUser();
        #region Singleton Pattern 
        protected static LoginForm _Instance { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }
        public static LoginForm Instance
        {

            get
            {
                if (_Instance == null || _Instance.IsDisposed)
                    _Instance = new LoginForm();

                return _Instance;
            }
        }
        #endregion
        private void btnOk_Click(object sender, EventArgs e)
        {
            btnOk.Text = "&Wait....";
            try
            {
                if (txtUsername.Text == string.Empty || txtUsername.Text.Length<5)
                {
                    txtUsername.Focus();
                    pnlTextBoxUserName.Visible = true;
                    lblUsernameError.ForeColor = Color.Red;
                    btnOk.Text = "&Enter";
                    return;
                }
                else if (txtPassword.Text == string.Empty || txtPassword.Text.Length < 5)
                {
                    txtPassword.Focus();
                    pnlTextBoxUPassword.Visible = true;
                    lblPasswordError.ForeColor = Color.Red;
                    btnOk.Text = "&Enter";
                    return;
                }
               
                //Get passwords
                var enteredPassword = processUser.Encrypt(txtPassword.Text);
                var databasePassword = processUser.GetUserPasswordByName(txtUsername.Text);

                if (databasePassword != null)
                {

                    User user = new User();

                    if (databasePassword == enteredPassword)
                    {
                        user = processUser.GetUser(txtUsername.Text, databasePassword);

                        user.IsLoggedin = true;
                        processUser.UpdateUser(user);


                        btnOk.Text = "&Enter";
                      
                        MainForm.Instance(user); //create an instance of form 3
                        this.Hide();             //hide me (form2)
                        MainForm.Instance().Show();       //show form3
                        this.Close();

                    }
                    else
                    {
                        btnOk.Text = "&Enter";
                        MessageBox.Show("Sorry the Password you entered is incorect");
                    }
                }
                else
                {
                    btnOk.Text = "&Enter";
                    MessageBox.Show("Sorry the Username you entered is not existing");
                }
            }
            catch (Exception ex)
            {
                btnOk.Text = "&Enter";
                MessageBox.Show("Error: " + ex.Message);
            }
           
        }

        private void CloseThisForm()
        {
            this.Close();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            try
            {
                txtUsername.Focus();
                ProcessUser processUser = new ProcessUser();

                if (Properties.Settings.Default.Username != string.Empty)
                {
                    txtUsername.Text = Properties.Settings.Default.Username;
                    txtPassword.Text = Properties.Settings.Default.userPassword;
                    checkBoxRemember.Checked = true;
                }
            }
            catch (Exception)
            {
                
            }

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void btnVisiblePass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = (char)0;
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void checkBoxRemember_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (checkBoxRemember.Checked)
                {
                    Properties.Settings.Default.Username = txtUsername.Text;
                    Properties.Settings.Default.userPassword = txtPassword.Text;
                    Properties.Settings.Default.Save();

                }
                else if (!checkBoxRemember.Checked && checkBoxRemember.ThreeState == false)
                {
                    Properties.Settings.Default.Username = string.Empty;
                    Properties.Settings.Default.userPassword = string.Empty;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {

            }

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            pnlTextBoxUserName.Visible = false;
            lblUsernameError.ForeColor = SystemColors.MenuHighlight;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            pnlTextBoxUPassword.Visible = false;
            lblPasswordError.ForeColor = SystemColors.MenuHighlight;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
