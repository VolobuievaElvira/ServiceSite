using ClassLibrary.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces.Data
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        void AddUser(User user);
        void RemoveUser(User user);
    }
}
