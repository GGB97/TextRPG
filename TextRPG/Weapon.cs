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
        if(player.eWeapon == null)  //무기를 끼고 있지 않다면
        {
            player.eWeapon = this;
        }
        else
        {
            player.eWeapon.unEquip(player);
            player.eWeapon = this;
        }

        player.atk += atk;
    }
    public override void unEquip(Player player)
    {
        base.unEquip(player);
        player.atk -= atk;
    }

    public override void print()
    {
        Console.Write($"{name} | 공격력+{atk} | {description}");
    }

    public int Atk()
    {
        return atk;
    }
}
