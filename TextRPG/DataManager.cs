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

        Console.WriteLine(jsonStr); // 출력 대신 저장
    }

    public void Load(Player player)
    {
        //PlayerJsonModel sD2 = PlayerJsonModel.Deserialize(jsonStr);
        //Player p = PlayerJsonModel.ModelToPlayer(sD2);
    }
}
