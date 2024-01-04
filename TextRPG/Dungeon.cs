using System;

public class Dungeon
{
    int level;  //던전 난이도
	public int rSpec; // 권장 방어력
	int reward; // 보상
	public Dungeon(int level)
	{
        this.level = level;
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
        Random rand = new Random();
        int hpCost = rand.Next(20 + (rSpec - player.def), 36 + (rSpec - player.def));

        float n = rand.Next(player.atk, (player.atk * 2) + 1);
        float bonus = reward * (n * 0.1f);

        Console.WriteLine(
            "축하합니다!!\n" + 
            $"난이도 {level} 던전을 클리어 하였습니다.\n\n" + 
            "[탐험 결과]"
            );

        Console.Write($"생명력 : {player.hp} -> ");
        player.hp -= hpCost;
        Console.WriteLine($"{player.hp} (-{hpCost})");

        Console.Write($"소지금 : {player.gold} -> ");
        player.gold += reward + (int)bonus;
        Console.WriteLine($"{player.gold} G (+{reward + bonus})");
    }

    public void Fail(Player player)
    {
        Console.WriteLine(
            "아이고!!\n" +
            $"난이도 {level} 던전 클리어에 실패 했습니다.\n\n" +
            "[탐험 결과]"
            );
        Console.Write($"생명력 : {player.hp} -> ");
        player.hp -= playerConst.maxHp / 2;    // 그냥 실패하면 최대 체력의 절반 줄어들게 하고 싶어서.
        Console.WriteLine($"{player.hp} (-{playerConst.maxHp / 2})");
    }
}
