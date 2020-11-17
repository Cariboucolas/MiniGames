using System;

public class Player
{
	private string Name;

	public Player(string Player1)
	{
		Name = Player1;
	}

	public Player(string Player2)
	{
		Name = Player2;
	}
	public string ChooseName()
    {
		Console.ReadLine(Name);
	}
}
