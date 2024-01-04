using System;

public class Player
{
	int level;
	string name;
	string job;
	int atk;
	int def;
	int hp;
	int gold;

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
    }

	public void EquipManager()
	{
		Console.WriteLine("[장비 관리]");

		inventory.printNumbering();
		string str; int num;
		while (true)
		{
			Console.WriteLine("장착/해제 할 장비 : ");
			str = Console.ReadLine();

			num = int.Parse(str);
			if(0 <= num && num < inventory.items.Count)
			{
				if (inventory.items[num].getEquip())	// 아이템이 착용되어 있으면 장착 해제
				{
                    inventory.items[num].unEquip();
                }
				else
				{
                    inventory.items[num].Equip();	// 장비 장착
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
}
