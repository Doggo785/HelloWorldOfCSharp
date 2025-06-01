class Door(int passcode)
{
	private DoorState _state = DoorState.Closed;
    private int Passcode = passcode;

    public DoorState State => _state;
	public void Open()
	{
		if (_state == DoorState.Closed)
		{
			Console.WriteLine("The door is now open.");
			_state = DoorState.Open;
		}
		else
		{
			Console.WriteLine("You can't perform this action the current state is " + _state); ;
		}
	}
	public void Close()
	{
		if (_state == DoorState.Open)
		{
			Console.WriteLine("The door is now closed.");
			_state = DoorState.Closed;
		}
		else
		{
			Console.WriteLine("The door is already closed.");
		}
	}
	public void Lock(int passcodeAttempt)
	{
		if (_state != DoorState.Closed)
		{
			Console.WriteLine("You can only lock the door when it is closed.");
		}
		else if (passcodeAttempt == Passcode)
		{
			Console.WriteLine("The door is now locked.");
			_state = DoorState.Locked;
		}
		else
		{
			Console.WriteLine("Incorrect passcode. The door remains unlocked.");
		}
	}
	public void Unlock(int passcodeAttempt)
	{
		if (_state != DoorState.Locked)
					Console.WriteLine("You can only unlock the door when it is locked.");
		else if (passcodeAttempt == Passcode)
		{
			Console.WriteLine("The door is now unlocked.");
			_state = DoorState.Closed;
		}
		else
		{
			Console.WriteLine("Incorrect passcode. The door remains locked.");
		}
	}
	public void ChangePasscode(int oldPasscode, int newPasscode)
	{
		if (oldPasscode == Passcode)
		{
			Console.WriteLine("Passcode changed successfully.");
			Passcode = newPasscode;
		}
		else
		{
			Console.WriteLine("Incorrect old passcode. Passcode change failed.");
		}
	}

}

enum DoorState
{
	Open,
	Closed,
	Locked
}