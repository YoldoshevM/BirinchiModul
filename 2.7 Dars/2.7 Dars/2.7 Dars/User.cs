using System;
using System.Collections.Generic;
using System.Text;

namespace _2._7_Dars;

public class User
{


	private Guid UserId;

	public Guid userID
	{
		get { return UserId; }
		set { UserId = value; }
	}


	private string userName;

	public string UserName
	{
		get { return UserName; }
		set { UserName = value; }
	}


	private string password;

	public string Password
	{
		get { return password; }
		set { password = value; }
	}


	private string lastName;

	public string LastName
	{
		get { return lastName; }
		set { lastName = value; }
	}


	private string firstName;

	public string FirstName
	{
		get { return firstName; }
		set { firstName = value; }
	}







}
