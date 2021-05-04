using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //eepData kd;
    public string playerName;
    public int playerLives = 3;
    public float playerTime = 60.0f;
    public int score;

    public InputField playerNameIF;
    public Text playerNameText;
    public Text timeText;

    [System.Serializable]
    public class Save
    {
        public int score;
        public int name;
        public int lives;

    }

    public void Start()
    {
        score = ScoreKeeper.newScore;
        playerName = playerNameIF.text;
        playerNameText.text = playerName;
        playerTime = KeepData.PlayingTime;
    }

    public void SavePlayer()
    {
        PlayerPrefs.SetInt("Score", ScoreKeeper.newScore);
        PlayerPrefs.SetInt("Lives", KeepData.PlayerLives);
        PlayerPrefs.SetString("Name", KeepData.PlayerName);
        PlayerPrefs.SetFloat("Time", KeepData.PlayingTime);
    }

    public void LoadPlayer()
    {
        KeepData.PlayerLives = PlayerPrefs.GetInt("Lives");
        KeepData.PlayerName = PlayerPrefs.GetString("Name");
        ScoreKeeper.newScore = PlayerPrefs.GetInt("Score");
        KeepData.PlayingTime = PlayerPrefs.GetFloat("Time");
    }

    private Save CreateSaveGameObject()
    {
        Save save = new Save();
        save.score = score;
        return save;
    }

    public void SaveAsJSON()
    {
        Save save = CreateSaveGameObject();
        string json = JsonUtility.ToJson(save);


        Debug.Log("saving to JSON: " + json);
    }


    public void SetName()
    {
        playerName = playerNameIF.text;
    }
}
