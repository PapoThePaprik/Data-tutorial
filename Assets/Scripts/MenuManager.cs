using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    public string highScorePlayerName;
    public int highScore;
    public string currentPlayerName;


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }


        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadHighScore();

    }


	[System.Serializable]
    class SaveData
	{
        public string playerName;
        public int score;

    }



    public void SaveHighScore()
	{
            SaveData data = new SaveData();
            data.playerName = highScorePlayerName;
            data.score = highScore;

            string json = JsonUtility.ToJson(data);

            File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

   
    public void LoadHighScore()
    {


            string path = Application.persistentDataPath + "/savefile.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                SaveData data = JsonUtility.FromJson<SaveData>(json);

                highScorePlayerName = data.playerName;
                highScore = data.score;
            }
    }

    public void ResetHighScore()
	{
        SaveData data = new SaveData();
        highScorePlayerName = "";
        highScore = 0;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);

        LoadHighScore();
	}


	
}
