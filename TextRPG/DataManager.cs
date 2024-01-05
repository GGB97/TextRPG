using System;
using System.Text.Json;

public class DataManager
{
	public static DataManager I = new DataManager();
    PlayerJsonModel sD;
    public string jsonStr;

	public void Save(Player player)
	{
        sD = new PlayerJsonModel(player);
        jsonStr = sD.SerializeToString();

        //Console.WriteLine(jsonStr);
        File.WriteAllText($"SaveData_{player.name}.json", jsonStr);
    }

    public void Load(Player player)
    {
        //PlayerJsonModel sD2 = PlayerJsonModel.Deserialize(jsonStr);
        //Player p = PlayerJsonModel.ModelToPlayer(sD2);
    }
}
