using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class HighScoreKeeper : MonoBehaviour
{
    public Text highScoreDisplay;
    private static string[] highScoreList;
    string wordList;

    // Start is called before the first frame update
    void Start()
    {
        highScoreList = File.ReadAllLines("Assets/scores.txt");
        wordList = highScoreList[10];
        highScoreDisplay.text = wordList;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
