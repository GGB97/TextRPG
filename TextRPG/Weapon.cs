using System;
using System.Runtime.CompilerServices;

public class Weapon : Item
{
    bool is_Equip = false;
    int atk;

    Weapon()
    {
        type = (int)ItemType.Weapon;
    }

    public override void print()
    {
        Console.WriteLine($" {name}\t|공격력+{atk}\t| {description}");
    }

    public int Atk()
    {
        return atk;
    }
}
