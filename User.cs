using System;

public class User
{
	public Guide Id = { get; private set;  }

	public string Name = { get; private set; }
	public string Email = { get; private set; }
	public string Password = { get; private set; }
	public string Photo = { get; private set; }
	
	public UserRole UserRole { get; private set; }

	private string _name;
	private string email;
	private string password;
	private string photo;

	public User()
	{
		Id = Guid.NewGuid();
	}
}
