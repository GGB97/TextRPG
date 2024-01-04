namespace TextRPG
{
    internal class GameManager
    {
        Player player;
        Shop shop;

        public GameManager()
        {
            player = new Player("GGB");
            shop = new Shop();
        }

        public void GameStart()
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");

            while (true)
            {
                Console.WriteLine("1. 상태 보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");

                Console.Write($"{player.getName()} : ");
                string str = Console.ReadLine();
                if (str == "1")
                {
                    // 상태 보기
                    player.printStatus();

                    while (true)
                    {
                        Console.WriteLine("1. 나가기");
                        Console.Write($"{player.getName()} : ");
                        str = Console.ReadLine();

                        if (str == "1")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                        }
                    }
                }
                else if (str == "2")
                {
                    // 인벤토리
                    player.printInven();

                    while (true)
                    {
                        Console.WriteLine("1. 장착 관리");
                        Console.WriteLine("2. 나가기");
                        Console.Write($"{player.getName()} : ");
                        str = Console.ReadLine();

                        if (str == "1")
                        {
                            //장비 관리
                            player.EquipManager();
                            break;
                        }
                        if (str == "2")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                        }
                    }
                }
                else if (str == "3")
                {
                    // 상점
                    Console.Write($"보유 골드 : {player.gold}");
                    shop.print();
                    Console.WriteLine("1. 아이템 구매");
                    Console.WriteLine("2. 아이템 판매");
                    Console.WriteLine("3. 나가기");

                    Console.Write($"{player.getName()} : ");
                    str = Console.ReadLine();

                    if (str == "1")
                    {
                        // 아이템 구매
                        
                        break;
                    }
                    if (str == "2")
                    {
                        // 아이템 판매
                        break;
                    }
                    if (str == "3")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
            }

        }

        static void Main(string[] args)
        {
            GameManager gm = new GameManager();
            gm.GameStart();
        }
    }
}
