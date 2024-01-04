using System;

public class Armor : Item
{
    int def;

    Armor()
    {
        type = (int)ItemType.Armor;
    }
    public Armor(string name, string des, int def, int cost)
    {
        type = (int)ItemType.Weapon;
        this.name = name;
        this.description = des;
        this.def = def;
        this.cost = cost;
    }

    public override void Equip(Player player)
    {
        base.Equip(player);
        player.def += def;
    }
    public override void unEquip(Player player)
    {
        base.unEquip(player);
        player.def -= def;
    }

    public override void print()
    {
        Console.WriteLine($"{name} | 방어력+{def} | {description}");
    }

    public int Def()
    {
        return def;
    }
}
