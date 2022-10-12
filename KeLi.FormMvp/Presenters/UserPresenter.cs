using KeLi.FormMvp.Business.Services;
using KeLi.FormMvp.IViews;
using KeLi.FormMvp.Models;

namespace KeLi.FormMvp.Presenters
{
    public class UserPresenter
    {
        private readonly IUserLoginView _view;

        public UserPresenter(IUserLoginView view)
        {
            _view = view;
        }

        public void LoginSystem()
        {
            if (string.IsNullOrWhiteSpace(_view.UserName))
            {
                _view.ShowMessage("User name cannot empty!");

                return;
            }

            if (string.IsNullOrWhiteSpace(_view.Password))
            {
                _view.ShowMessage("Password cannot empty!");

                return;
            }

            if (!_view.ShowConfirm("Are you sure to login system?"))
                return;

            var mod = new User
            {
                UserName = _view.UserName,
                Password = _view.Password
            };

            var user = BusinessUserService.GetItem(mod.UserName);
            var message = user.Password == mod.Password ? "Logins successful!" : "Logins failed!";

            _view.ShowMessage(message);
        }
    }
}