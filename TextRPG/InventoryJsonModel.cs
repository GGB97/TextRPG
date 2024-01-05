using Newtonsoft.Json;
using System;

public class InventoryJsonModel
{
    public List<ItemJsonModel> items = new List<ItemJsonModel>(); // 인벤토리를 리스트로 하는건 낭비같긴 하지만 최대 용량을 생각하기 귀찮아서..

    public InventoryJsonModel(Inventory inven)
	{
		foreach (var item in inven.items)
		{
			if (item.GetType() == typeof(Weapon))
			{
				items.Add(new WeaponJsonModel((Weapon)item));
			}
			else if (item.GetType() == typeof(Armor))
            {
                items.Add(new ArmorJsonModel((Armor)item));
            }
        }
	}

    public string getInvenJson()
    {
        string jsonStr;
        jsonStr = JsonConvert.SerializeObject(this);
        return jsonStr;
    }
}
