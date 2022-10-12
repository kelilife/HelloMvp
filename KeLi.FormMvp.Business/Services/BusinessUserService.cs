using KeLi.FormMvp.Business.Models;
using KeLi.FormMvp.Persistence.Services;

namespace KeLi.FormMvp.Business.Services
{
    public class BusinessUserService
    {
        public static int AddItem()
        {
            return 1;
        }

        public static int DeleteItem()
        {
            return 1;
        }

        public static int UpdateItem()
        {
            return 1;
        }

        public static BusinessUser GetItem(string userName)
        {
            var user = PersistenceUserService.GetItem(userName);

            return new BusinessUser(user.UserName, user.Password);
        }
    }
}