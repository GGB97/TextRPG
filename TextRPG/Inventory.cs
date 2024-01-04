﻿using System;

public class Inventory
{
    public List<Item> items = new List<Item>(); // 인벤토리를 리스트로 하는건 낭비같긴 하지만 최대 용량을 생각하기 귀찮아서..

    public void print()
    {
        if(items != null)
        {
            Console.WriteLine("[아이템 목록]");
            foreach (Item item in items)
            {
                if (item.getEquip())
                    Console.Write("[E]");

                item.print();
                Console.WriteLine();
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
                Console.Write($"{num++}. ");

                if (item.getEquip())
                    Console.Write("[E]");

                item.print();
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("아이템이 없습니다.");
        }
    }
}
