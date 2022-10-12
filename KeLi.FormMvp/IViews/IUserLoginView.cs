namespace KeLi.FormMvp.IViews
{
    public interface IUserLoginView
    {
        string UserName { get; set; }

        string Password { get; set; }

        void ShowMessage(string msg);

        bool ShowConfirm(string msg);

        void LoginSys();
    }
}