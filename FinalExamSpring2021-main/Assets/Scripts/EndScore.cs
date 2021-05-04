using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    public Text displayScore;
    public Text displayHighScore;
    private int score;
    private int highscore;

    // Start is called before the first frame update
    void Start()
    {
        score = ScoreKeeper.newScore;
        highscore = PlayerPrefs.GetInt("HighScore");
        displayScore.text = "Score: " + score;
        displayHighScore.text = "High Score: " + highscore;
    }

}
