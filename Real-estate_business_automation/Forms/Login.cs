using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Real_estate_business_automation.Repositories;
using System.Configuration;
using Real_estate_business_automation.Controllers;

namespace Real_estate_business_automation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (!Controller.Login(LoginBox.Text, PasswordBox.Text))
            {
                MessageBox.Show(this, "Invalid user name or password", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
