using System;

public class Item
{
    protected int type;
    protected string name;
    protected string description;

    public virtual void print()
    {
        Console.WriteLine($" {name}\t| {description}");
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


