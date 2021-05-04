using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    //private KeepData kd;
    //private PlayerData pd;
    public Text timeLimitText;
    public Text remainingTimeText;

    public float timelimit = 30f;
    public float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        //timeRemaining = Player.playerTime;
        timelimit = KeepData.PlayingTime;
        timeRemaining = timelimit;

        timeLimitText.text = timelimit.ToString("F2");
        remainingTimeText.text = timeRemaining.ToString("F2");
    }


    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining >= 0)
        {
            remainingTimeText.text = timeRemaining.ToString("F2");
        }
        else
        {
            remainingTimeText.text = "game over";
        }

    }
}
