using System;
using System.Text.Json;

public class DataManager
{
	public static DataManager I = new DataManager();

	public void Save(Player player)
	{
        PlayerJsonModel sD = new PlayerJsonModel(player);
        string jsonStr = sD.SerializeToString();

        //Console.WriteLine(jsonStr);
        File.WriteAllText($"SaveData_{player.name}.json", jsonStr);
    }

    public Player Load(Player player)
    {
        // 추후 세이브 데이터 선택 기능 추가 예정
        string jsonStr = File.ReadAllText($"SaveData_{player.name}.json");

        PlayerJsonModel sD = PlayerJsonModel.Deserialize(jsonStr);
        Player playerData = PlayerJsonModel.ModelToPlayer(sD);

        return playerData;
    }
}
