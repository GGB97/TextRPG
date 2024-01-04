using System;

public class Shop
{
    public List<Item> items = new List<Item>();

    public Shop()
	{
        items.Add(new Armor("수련자 갑옷", "수련에 도움을 주는 갑옷", 5, 1000));
        items.Add(new Armor("스파르타의 갑옷", "스파르타의 전사들이 사용하던 갑옷", 15, 3500));
        items.Add(new Weapon("청동 도끼", "어디선가 사용됐던거 같은 도끼", 5, 1500));
        items.Add(new Weapon("스파르타의 창", "스파르타의 전사들이 사용하던 창", 7, 5000));
    }

    public void print()
    {
        int num = 1;
        foreach (Item item in items)
        {
            Console.Write($"{num++}. ");
            item.print();
            Console.WriteLine();
        }
    }
}
