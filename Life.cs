using System;

public class Life
{
	private int _life;

	public void life(int life)
	{
		life = Mot.Count() - 2; 
		if (_life > 0)
        {
			this._life = life - 1;
		}	
	}
	public int GetLife(int life)
	{
		return _life = life; 
	}

}
