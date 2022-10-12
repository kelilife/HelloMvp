namespace KeLi.FormMvp.Persistence.Models
{
    public class PersistenceUser
    {
        public PersistenceUser(string userName, string password)
        {
            Password = password;
            UserName = userName;
        }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}