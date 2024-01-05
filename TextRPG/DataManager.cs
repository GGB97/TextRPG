using System;
using System.Text.Json;

public class DataManager
{
	public static DataManager I = new DataManager();
    PlayerJsonModel sD;
	public void Save(Player player)
	{
        sD = new PlayerJsonModel(player);
        string str = sD.getPlayerJson();

        Console.WriteLine(str);
        Console.WriteLine();
    }
}
