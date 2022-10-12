using System;

using KeLi.FormMvp.Persistence.Models;

namespace KeLi.FormMvp.Persistence.Services
{
    public class PersistenceUserService
    {
        public static int AddItem(PersistenceUser user)
        {
            if (user is null)
                throw new ArgumentNullException(nameof(user));

            return 1;
        }

        public static int DeleteItem(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
                throw new ArgumentNullException(nameof(userName));

            return 1;
        }

        public static int UpdateItem(PersistenceUser user)
        {
            if (user is null)
                throw new ArgumentNullException(nameof(user));

            return 1;
        }

        public static PersistenceUser GetItem(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
                throw new ArgumentNullException(nameof(userName));

            return new PersistenceUser(userName, "123456");
        }
    }
}