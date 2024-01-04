using System;
using System.Runtime.CompilerServices;

public class Weapon : Item
{
    int atk;

    public Weapon()
    {
        type = (int)ItemType.Weapon;
    }
    public Weapon(string name, string des, int atk, int cost)
    {
        type = (int)ItemType.Weapon;
        this.name = name;
        this.description = des;
        this.atk = atk;
        this.cost = cost;
    }

    public override void Equip(Player player)
    {
        base.Equip(player);
        player.atk += atk;
    }
    public override void unEquip(Player player)
    {
        base.unEquip(player);
        player.atk -= atk;
    }

    public override void print()
    {
        Console.WriteLine($"{name} | 공격력+{atk} | {description}");
    }

    public int Atk()
    {
        return atk;
    }
}
