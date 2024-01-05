using System;

public class Armor : Item
{
    int def;

    public Armor(string name, string des, int def, int cost)
    {
        type = (int)ItemType.Armor;
        this.name = name;
        this.description = des;
        this.def = def;
        this.cost = cost;
    }

    public override void Equip(Player player)
    {
        base.Equip(player);
        if (player.eArmor == null)  //무기를 끼고 있지 않다면
        {
            player.eArmor = this;
        }
        else
        {
            player.eArmor.unEquip(player);
            player.eArmor = this;
        }

        player.def += def;
    }
    public override void unEquip(Player player)
    {
        base.unEquip(player);
        player.eArmor = null;
        player.def -= def;
    }

    public override void print()
    {
        Console.Write($"{name} | 방어력+{def} | {description}");
    }

    public int getDef()
    {
        return def;
    }
}
