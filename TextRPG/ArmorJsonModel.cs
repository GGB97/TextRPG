using Newtonsoft.Json;
using System;

public class ArmorJsonModel : ItemJsonModel
{
	public float def { get; set; }
    public ArmorJsonModel(Armor armor)
	{
        is_Equip = armor.getEquip();
        type = armor.getType();
        name = armor.getName();
        description = armor.getDesc();
        cost = armor.cost;

        def = armor.getDef();
    }

    public string SerializeToString()
    {
        string jsonStr;
        jsonStr = JsonConvert.SerializeObject(this);

        return jsonStr;
    }
}
