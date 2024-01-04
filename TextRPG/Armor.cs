using System;

public class Armor : Item
{
    bool is_Equip = false;
    int def;

    Armor()
    {
        type = (int)ItemType.Armor;
    }

    public override void print()
    {
        Console.WriteLine($" {name}\t|방어력+{def}\t| {description}");
    }

    public int Def()
    {
        return def;
    }
}
