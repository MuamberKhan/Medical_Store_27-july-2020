using MSS_Process;
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
    public partial class ContactForm : Form
    {
        #region Singleton Pattern 
        protected static ContactForm _Instance { get; set; }
        public ContactForm()
        {
            InitializeComponent();

        }
        public static ContactForm Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ContactForm();

                return _Instance;
            }
        }
        #endregion

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            ProcessAboutme processAbout = new ProcessAboutme();
            var result=processAbout.validateEmail(txtEmail.Text);
            if (!result)
            {
                txtEmail.Focus();
                txtEmail.Clear();
            }
            else
            {
                processAbout.Send_Email(txtName.Text,txtEmail.Text,txtMessage.Text);
            }
        }
    }
}
