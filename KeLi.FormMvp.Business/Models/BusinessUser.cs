namespace KeLi.FormMvp.Business.Models
{
    public class BusinessUser
    {
        public BusinessUser(string userName, string password)
        {
            Password = password;
            UserName = userName;
        }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}