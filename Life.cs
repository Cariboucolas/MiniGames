using System;
using System.Collections.Generic;

public class Life
{
	private int _life = 10;

	public void life(int life)
	{ 
		if (_life > 0)
        {
			this._life = life - 1;
		}	

	}
	public int GetLife()
	{
		return _life;
	}

}
