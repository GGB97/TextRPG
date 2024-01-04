using System;

public class Armor : Item
{
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
