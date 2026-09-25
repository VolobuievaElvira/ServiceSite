using ClassLibrary.Enums;
using System;

namespace ClassLibrary.Users
{
	public class User
	{
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Photo { get; private set; }
        public UserRole UserRole { get; private set; }
       
		public User(int id, string name, string email, string password)
		{
			Id = id;
			ChangeName(name);
			ChangeEmail(email);
			ChangePassword(password);
        }

        public bool VerifyPassword(string inputPassword)
        {
            return Password == inputPassword;
        }
        public void ChangeRole(UserRole role) => UserRole = role;
        public void ChangeName(string name) => Name = name;
        public void ChangeEmail(string email) => Email = email;
        public void ChangePassword(string password) => Password = password;
        public void ChangePhoto(string photo) => Photo = photo;
    }
}