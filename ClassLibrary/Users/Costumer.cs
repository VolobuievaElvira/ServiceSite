using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Enums;

namespace ClassLibrary.Users
{
    public class Costumer: User
    {
        public Country? Country { get; private set; }

        public Costumer(int id, string name, string email, string password) : base(id, name, email, password)
        {
            ChangeRole(UserRole.Costumer);
        }

        public void UpdateCountry(Country country) => Country = country;
    }
}
