using System;

public class DungeonManager
{
    public void Select(Player player)
    {
        string str;

        Console.WriteLine("[던전 선택] --- (0. 나가기)");

        while (true)
        {
            Console.WriteLine(
                "1. 난이도 1 (방어력 8 이상 권장) \n" +
                "2. 난이도 2 (방어력 10 이상 권장) \n" +
                "3. 난이도 3 (방어력 20 이상 권장) \n"
                );
            Console.Write($"{player.getName()} : ");
            str = Console.ReadLine();

            if (str == "1" || str == "2" || str == "3")
            {
                Enter(player, int.Parse(str));
                break;
            }
            else if (str == "0")
            {
                break;
            }
            else
            {
                Console.Write($"{str} 은(는) 잘못된 입력입니다.");
            }
        }
    }

    public void Enter(Player player, int level)
    {
        Console.WriteLine($"난이도 {level} 던전에 입장합니다.\n");
        Dungeon dungeon = new Dungeon(level);
        Random rand = new Random(); int num;

        if(player.def >= dungeon.rSpec)  // 권장 방어력보다 player의 방어력이 높거나 같다면
        {
            dungeon.Clear(player);
        }
        else    // 권장 방어력보다 player의 방어력이 낮다면
        {
            num = rand.Next(0, 100);

            // 여기서 던전 실패 값을 0~39으로 하는것과 0~100을 단위별로(ex)5 단위로 8개) 쪼개서 하는것 중에 어떤게 더 공평할지?
            // 랜덤이라 의미는 없을 것 같지만 뭔가 0~39 구간을 전부 실패로 처리하면 뭔가 거슬리는 느낌?
            // 아니면 다른 추가적인 방법은 어떤게 있는지 궁금합니다.

            if (0 < num && num < 40) // 0~40이면 던전 실패
            {
                dungeon.Fail(player);
            }
            else    // 던전 클리어
            {
                dungeon.Clear(player);
            }
        }
    }
}
