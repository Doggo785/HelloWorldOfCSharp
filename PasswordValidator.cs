class PasswordValidator
{
	public static bool IsValid(string password)
	{
		if (string.IsNullOrEmpty(password))
		{
			return false;
		}
		if (password.Length < 6 || password.Length > 13)
		{
			return false;
		}
		if (!ContainsUpperCase(password) || !ContainsLowerCase(password) || !ContainsDigit(password) || ContainsUpperTOrAmpersand(password))
		{
			return false;
		}
		return true;
	}
	private static bool ContainsUpperCase(string password)
	{
		foreach (char c in password)
		{
			if (char.IsUpper(c))
			{
				return true;
			}
		}
		return false;
	}
	private static bool ContainsLowerCase(string password)
	{
		foreach (char c in password)
		{
			if (char.IsLower(c))
			{
				return true;
			}
		}
		return false;
	}
	private static bool ContainsDigit(string password)
	{
		foreach (char c in password)
		{
			if (char.IsDigit(c))
			{
				return true;
			}
		}
		return false;
	}

	private static bool ContainsUpperTOrAmpersand(string password)
	{
		foreach (char c in password)
		{
			if (c == 'T' || c == '&')
			{
				return true;
			}
		}
		return false;
	}
}