using System;
using System.Text.Json;

public class PlayerJsonModel
{
    public int level { get; set; }
    public int exp { get; set; }
    public int maxExp { get; set; }
    public string name { get; }
    public string job { get; set; }
    public int hp { get; set; }
    public int gold { get; set; }
    public float atk { get; set; }
    public int def { get; set; }

    public string invenStr { get; set; }
    public string weponStr { get; set; }
    public string armorStr { get; set; }


    private InventoryJsonModel inventory;
    private WeaponJsonModel eWeapon;
    private ArmorJsonModel eArmor;

    public PlayerJsonModel(Player player) 
    {
        level = player.getLevel();
        exp = player.exp;
        maxExp = player.getmaxExp();
        name = player.name;
        job = player.getJob();
        hp = player.hp;
        gold = player.gold;
        atk = player.atk;
        def = player.def;

        inventory = new(player.inventory);
        eWeapon = new(player.eWeapon);
        eArmor = new(player.eArmor);

        invenStr = inventory.SerializeToString();
        weponStr = eWeapon.SerializeToString();
        armorStr = eArmor.SerializeToString();
    }

    public string SerializeToString()
    {
        var option = new JsonSerializerOptions() { WriteIndented = true };
        string jsonStr = JsonSerializer.Serialize(this, option);

        return jsonStr;
    }
}
