using ClassLibrary.Enums;
using ClassLibrary.Interfaces.Data;
using ClassLibrary.Interfaces.Profile;
using ClassLibrary.Interfaces.Services;
using ClassLibrary.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ProfileManagementService
{
    class CostumerProfileManagementService: UserProfileManagementService, ICostumerProfileManagementService
    {
        public CostumerProfileManagementService(IUserRepository userRepository, ICurrentUserService currentUserService)
            : base(userRepository, currentUserService)
        {
        }
        public void UpdateCountry(Costumer costumer, Country country)
        {
            costumer.UpdateCountry(country);
        }
    }
}
