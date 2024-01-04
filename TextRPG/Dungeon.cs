using System;

public class Dungeon
{
	public int rSpec; // 권장 방어력
	int reward; // 보상
	public Dungeon(int level)
	{
		if(level == 1)
		{
			rSpec = 5;
			reward = 1000;
		}
        else if (level == 2)
        {
            rSpec = 10;
            reward = 1700;
        }
        else if (level == 3)
        {
            rSpec = 20;
            reward = 2500;
        }
    }

    public void Clear(Player player)
    {

    }

    public void Fail(Player player)
    {

    }
}
