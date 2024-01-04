using System;

public class Item
{
    protected bool is_Equip;
    protected int type;
    protected string name;
    protected string description;

    protected Item()
    {
        is_Equip = false;
    }

    public void Equip()
    {

    }
    public void unEquip()
    {

    }

    public virtual void print()
    {
        Console.WriteLine($" {name}\t| {description}");
    }

    public bool getEquip()
    {
        return is_Equip;
    }
    public int Type()
    {
        return type;
    }
    public string Name()
    {
        return name;
    }
    public string Description()
    {
        return description;
    }
}


