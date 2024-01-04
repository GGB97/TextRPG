using System;
using System.Numerics;

public class Player
{
    int level;
    string name;
    string job;
    int hp;
    public int gold { get; set; }
    public int atk { get; set; }
    public int def { get; set; }

    Inventory inventory;

    public Player(string name)
    {
        level = 1;
        this.name = name;
        job = "용병";
        atk = 10;
        def = 5;
        hp = 100;
        gold = 1500;
        inventory = new Inventory();

        inventory.items.Add(new Weapon("녹슨 검", "오래된 검", 2, 50));
        inventory.items.Add(new Armor("녹슨 갑옷", "오래된 갑옷", 5, 100));
    }

    public void EquipManager()
    {
        Console.WriteLine("[장비 관리]");

        inventory.printNumbering();
        string str; int num;
        while (true)
        {
            Console.Write("장착/해제 할 장비 : ");
            str = Console.ReadLine();

            int.TryParse(str, out num);
            if (0 <= num && num <= inventory.items.Count)
            {
                num -= 1;
                if (inventory.items[num].getEquip()) // 아이템이 착용되어 있는지 확인
                {
                    inventory.items[num].unEquip(this); // 장비 해제
                    break;
                }
                else
                {
                    inventory.items[num].Equip(this);	// 장비 장착
                    break;
                }
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
            }

        }
    }

    public void printStatus()
    {
        Console.WriteLine(
            $"LV : {level} \n" +
            $"{name} (job) \n" +
            $"공격력 : {atk} \n" +
            $"방어력 : {def} \n" +
            $"생명력 : {hp} \n" +
            $"소지금 : {gold} G"
            );
    }
    public void printInven()
    {
        inventory.print();
    }

    public string getName()
    {
        return name;
    }
}
