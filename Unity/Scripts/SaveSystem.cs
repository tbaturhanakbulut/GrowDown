/*using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
   public static void SaveInfos()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/save.pelit";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(enemyDetector,  magnetTimer, drillManager);
        formatter.Serialize(stream,data);
        stream.Close();

    }
    public static GameData LoadPlayer()
    {
        
    }
}
*/