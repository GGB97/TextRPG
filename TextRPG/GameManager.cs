namespace TextRPG
{
    internal class GameManager
    {
        Player player;

        public GameManager()
        {
            player = new Player("GGB");
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

                string str = Console.ReadLine();
                if (str == "1")
                {
                    // 상태 보기
                    player.printStatus();
                    break;
                }
                else if (str == "2")
                {
                    // 인벤토리
                    break;
                }
                else if (str == "3")
                {
                    // 상점
                    break;
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
