using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// this script is attached to the camera. It executes when the camera awakes and loads the values in the text boxes on the panel so you don't have to click a button.

public class ShowData : MonoBehaviour
{
    public Text PanelNameText;
    public Text PanelLivesText;
    public Text PanelTimeText;

    private void Awake()
    {
        PanelNameText.text = "Name: " + KeepData.PlayerName;
        PanelLivesText.text = KeepData.PlayerLives.ToString();
        PanelTimeText.text = KeepData.PlayingTime.ToString();

    }

}

