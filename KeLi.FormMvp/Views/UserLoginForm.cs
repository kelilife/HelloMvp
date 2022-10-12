using System;
using System.Windows.Forms;

using KeLi.FormMvp.IViews;
using KeLi.FormMvp.Presenters;

namespace KeLi.FormMvp.Views
{
    public partial class UserLoginForm : Form, IUserLoginView
    {
        private readonly UserPresenter _pst;

        public UserLoginForm()
        {
            InitializeComponent();

            _pst = new UserPresenter(this);
        }

        public string UserName { get; set; }

        public string Password { get; set; }

        public void ShowMessage(string msg)
        {
            MessageBox.Show(msg);
        }

        public bool ShowConfirm(string msg)
        {
            var result = MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return result == DialogResult.OK;
        }

        public void LoginSys()
        {
            _pst.LoginSystem();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserName = txtUserName.Text.Trim();

            Password = txtPwd.Text.Trim();

            LoginSys();
        }
    }
}