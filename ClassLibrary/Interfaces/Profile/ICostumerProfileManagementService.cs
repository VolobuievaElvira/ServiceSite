using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Enums;
using ClassLibrary.Users;

namespace ClassLibrary.Interfaces.Profile
{
    interface ICostumerProfileManagementService : IUserProfileManagementService
    {
        void UpdateCountry(Costumer costumer, Country country);
    }
}
