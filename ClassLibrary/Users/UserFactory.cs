using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Users
{
    public class UserFactory
    {
        private int _idCounter = 0;
        public User CreateCostumer(string name, string email, string password)
        {
            User user = new(++_idCounter, name, email, password);
            user.ChangeRole(Enums.UserRole.Costumer);

            return user;
        }

        public User CreateMaster(string name, string email, string password)
        {
            return new Master(++_idCounter, name, email, password);
        }

        public User CreateAdmin(string name, string email, string password)
        {
            User user = new(++_idCounter, name, email, password);
            user.ChangeRole(Enums.UserRole.Admin);

            return user;
        }
    }
}
