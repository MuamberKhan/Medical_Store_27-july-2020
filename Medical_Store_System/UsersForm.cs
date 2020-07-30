using BusinessLogic;
using LocalDataBase;
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
    public partial class UsersForm : Form
    {
        ProcessUser processUser = new ProcessUser();


        #region Singleton Pattern 
        protected static UsersForm _Instance { get; set; }
        public UsersForm()
        {
            InitializeComponent();
        }
        public static UsersForm Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new UsersForm();

                return _Instance;
            }
        }
        #endregion
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Control control = CheckValidity();
                if (control != null)
                {
                    control.Focus();                   
                    control.BackColor = Color.LightGray;
                    lblError.Text = "Some fields are not filled please view them carefully.";
                    return;
                }
                int[] digits = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                if (txtPassword.TextLength<8 && txtPassword.Text.Contains(digits.Any().ToString()))
                {
                    txtPassword.Focus();
                    pnltxtPassword.Visible = true;
                }
                else
                {
                    User user = new User()
                    {
                        Username = txtUserName.Text,
                        Password = txtPassword.Text,
                        Type = comboType.Text
                    };
                    bool isExists=processUser.UserExist(user);
                    if (!isExists)
                    {
                        processUser.CreateUser(user);
                        lblError.Visible = true;
                        lblError.Text = "User created successfully";
                        lblError.ForeColor = SystemColors.MenuHighlight;
                        loadUsers();
                    }
                    else
                    {
                        var message = "Sorry try another name, this username has been taken";
                        var tittle = "Warning!";
                        var dialogButtons = MessageBoxButtons.OK;
                        var dialogIcon = MessageBoxIcon.Error;
                        MessageBox.Show(message,tittle,dialogButtons,dialogIcon);
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private Control CheckValidity()
        {

            if (string.IsNullOrEmpty(txtUserName.Text) || txtUserName.Text.Length<5)
            {
                pnltxtUserName.Visible = true;
                return txtUserName;
            }
            if (string.IsNullOrEmpty(txtPassword.Text)|| txtPassword.Text.Length<8) {
                pnltxtPassword.Visible = true;
                return txtPassword;
            }

            if (string.IsNullOrEmpty(txtReEnterPass.Text))
            {
                pnltxtReEnterPass.Visible = true;
                return txtReEnterPass;
            }
            if (string.IsNullOrEmpty(comboType.Text)|| comboType.SelectedIndex<0)
            {
                pnlcomboType.Visible = true;
                return comboType;}
                
            else
                return null;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            loadUsers();
        }

        private void loadUsers()
        {
            try
            {
                List<User> users = processUser.GetUsers();
                dataGridUsers.AutoGenerateColumns = false;
                dataGridUsers.DataSource = users;
                    
            }
            catch (Exception ex)
            {
                lblError.Text = "Error: " + ex.Message;
                lblError.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.Instance().Show();
        }
    }
}
