using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Classes
{
    public class UserFactory
    {
        public User CreateCostumer(string name, string email, string password)
        {
            User user = new(name, email, password);
            user.PromoteToCostumer();

            return user;
        }

        public User CreateMaster(string name, string email, string password)
        {
            User user = new(name, email, password);
            user.PromoteToMaster();

            return user;
        }

        public User CreateAdmin(string name, string email, string password)
        {
            User user = new(name, email, password);
            user.PromoteToAdmin();

            return user;
        }
    }
}
