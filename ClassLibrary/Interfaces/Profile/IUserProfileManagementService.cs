using ClassLibrary.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces.Profile
{
    interface IUserProfileManagementService
    {
        void ChangeName(User user, string newName);
        void ChangeEmail(User user, string newEmail);
        void ChangePassword(User user, string oldPassword, string newPassword);
        void ChangePhoto(User user, string newPhotoPath);
        void DeleteAccount(User user);
    }
}
