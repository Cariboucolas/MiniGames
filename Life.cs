public class Life
{
    private int _life = 10;

    public void life(int life)
    {
        for (int i = 0; i < life; i++)
        {
            _life = 10;
            _life = life - 1;
        }
    }

    public int GetLife()
    {
        return _life;
    }
}