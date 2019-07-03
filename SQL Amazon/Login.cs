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
    public partial class Login : Form
    {
        private readonly Nile _nile;
        private Register _register;

        public event LoginSuccessEventHandler Success;

        public Login(Nile nile)
        {
            InitializeComponent();
            _nile = nile;
        }

        public void CloseLogin()
        {
            Close();
            Application.ExitThread();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_nile.VerifyUser(txtUsername.Text, txtPassword.Text))
            {
                OnSuccess(txtUsername.Text);
            }
            else
            {
                lblError.Text = "Username or password incorrect";
                ActiveControl = txtUsername;
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

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Enabled = false;
            _register = new Register(_nile);
            _register.Show();
            _register.Activate();
            _register.Success += Register_Success;
            _register.FormClosed += Register_Closed;
        }

        private void Register_Closed(object sender, FormClosedEventArgs e)
        {
            Enabled = true;
        }

        private void Register_Success(object sender, LoginSuccessEventArgs e)
        {
            _register.FormClosed -= Register_Closed;
            _register.Close();

            OnSuccess(e.Username);
        }
    }

    public class LoginSuccessEventArgs : EventArgs
    {
        public string Username { get; }

        public LoginSuccessEventArgs(string username)
        {
            Username = username;
        }
    }

    public delegate void LoginSuccessEventHandler(object sender, LoginSuccessEventArgs e);
}
