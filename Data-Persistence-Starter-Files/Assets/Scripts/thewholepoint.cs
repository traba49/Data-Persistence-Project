using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class thewholepoint : MonoBehaviour
{
    [System.Serializable]
    class SaveData
    {
        public string name;
        public int highscore;
    }

    public static thewholepoint Instance;
    public string pname;
    public string currname;
    public int phigh;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void Savename()
    {
        SaveData data = new SaveData();
        data.name = pname;
        data.highscore = phigh;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void Loadname()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            pname = data.name;
            phigh = data.highscore;
        }
    }
}
