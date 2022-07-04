using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class MainManager : MonoBehaviour
{
    public static MainManager instance;
    public string PlayerName;
    [SerializeField] Text PlayerNameText;
    
    // Encapsulation
    public string path { get; private set; }

    private void Awake()
    {
        this.path = Application.persistentDataPath + "/savefile.json";

        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    class SaveData
    {
        public string PlayerName;
    }

    public void SaveUserData()
    {
        SaveData data = new SaveData();
        data.PlayerName = PlayerName;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(path, json);
    }

    public void LoadUserData()
    {
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            PlayerName = data.PlayerName;
        }
    }
}
