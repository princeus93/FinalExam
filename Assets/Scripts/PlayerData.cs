using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[SerializeField]
public class PlayerData 
{

    public  string playerName;
    public  int playerLives;
    public  float playerTime;
    public int playerScore;


    public PlayerData(Player player)
    {
        playerName = player.playerName;
        playerLives = player.playerLives;
        playerTime = player.playerTime;
        playerScore = player.score;
    }
   
}
