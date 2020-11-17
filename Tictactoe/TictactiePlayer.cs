using System;

public class Player
{
	public string PlayerName { get; set; }

    

    public void ChooseName()
    {
		PlayerName = Console.ReadLine();
	}
}
