using System;

public class Inventory
{
    public List<Item> items = new List<Item>();

    public void print()
    {
        if(items != null)
        {
            Console.WriteLine("[아이템 목록]");
            foreach (Item item in items)
            {
                if (item.getEquip())
                    Console.Write("[E] ");

                item.print();
            }
        }
        else
        {
            Console.WriteLine("아이템이 없습니다.");
        }
    }

    public void printNumbering()
    {
        if (items != null)
        {
            int num = 1;
            Console.WriteLine("[아이템 목록]");
            foreach (Item item in items)
            {
                Console.Write(num++);

                if (item.getEquip())
                    Console.Write("[E] ");

                item.print();
            }
        }
        else
        {
            Console.WriteLine("아이템이 없습니다.");
        }
    }
}
