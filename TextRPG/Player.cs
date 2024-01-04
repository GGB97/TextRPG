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
}
