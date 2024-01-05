using Newtonsoft.Json;
using System;

public class WeaponJsonModel : ItemJsonModel
{
    public float atk { get; set; }
    public WeaponJsonModel(Weapon weapon)
    {
        is_Equip = weapon.getEquip();
        type = weapon.getType();
        name = weapon.getName();
        description = weapon.getDesc();
        cost = weapon.cost;

        atk = weapon.getAtk();
    }

    public string SerializeToString() 
    {
        string jsonStr;
        jsonStr = JsonConvert.SerializeObject(this);

        return jsonStr;
    }
}
