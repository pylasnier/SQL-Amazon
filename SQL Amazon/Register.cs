using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Amazon
{
    public partial class Register : Form
    {
        private readonly Nile _nile;

        public event LoginSuccessEventHandler Success;

        public Register(Nile nile)
        {
            InitializeComponent();
            _nile = nile;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPasswordAgain.Text)
            {
                lblError.Text = "Passwords don't match";
                ActiveControl = txtPasswordAgain;
                txtPasswordAgain.SelectAll();
            }
            else
            {
                if (_nile.RegisterUser(txtUsername.Text, txtPassword.Text))
                {
                    OnSuccess(txtUsername.Text);
                }
                else
                {
                    lblError.Text = "Username already taken";
                    ActiveControl = txtUsername;
                    txtUsername.SelectAll();
                }
            }
        }

        private void OnSuccess(string username)
        {
            Success?.Invoke(this, new LoginSuccessEventArgs(username));
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.SelectAll();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void txtPasswordAgain_Enter(object sender, EventArgs e)
        {
            txtPasswordAgain.SelectAll();
        }
    }
}
