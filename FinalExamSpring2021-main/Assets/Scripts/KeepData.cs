using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//THIS SCRIPT IS ATTACHED TO THE DATA MANAGER OBJECT PRESENT IN All THE SCENES

public class KeepData : MonoBehaviour
{
    private Player player;
    // STATIC so they are preserved between classes
    public static string PlayerName;
    public static int PlayerLives;
    public static float PlayingTime;

    public InputField PlayerNameInput;
    public Slider TimeSlider;
    public Dropdown ropdown;
    //lives are hard coded

    public Text showPlayerName; // don't forget to drop the hierarchy objects in the script slots in the inspector
    public Text showPlayerLives;
    public Text playingTimeText;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); // don't destroy this game object when a new scene is loaded.
        showPlayerName.text = "" + PlayerPrefs.GetString("PlayerName");

    }

    private void Update() //I left my timestamp on so you see that it updates in real time
    {
        Debug.Log(PlayerName + " has " + PlayerLives + " lives and " + PlayingTime + " speed.");
    }
    public void UpdateName() //executed in each letter change
    {
        //PlayerName = player.playerName;
        PlayerName = PlayerNameInput.text; // assign new input text to string
        Debug.Log(PlayerName); //prints updated name to log on each letter change
        showPlayerName.text = PlayerName; // show string in the textbox just to see that it works in the Intro scene. 
    }
    public void ShowName() //method for the show name button on intro
    {
        showPlayerName.text = PlayerName;
        Debug.Log(PlayerName);
    }

    public void SetLives() //method for clicking on "give 10 lives" button on intro
    {
        PlayerLives = ropdown.value;
        showPlayerLives.text = PlayerLives.ToString();
        Debug.Log(PlayerLives + " given");
    }
    public void ShowLives() //method for show lives button on game screen
    {
        showPlayerLives.text = PlayerLives.ToString();
        Debug.Log("lives: " + PlayerLives);
    }

    public void SetTime() //method for the slider on intro screen
    {
        PlayingTime = TimeSlider.value;
        playingTimeText.text = PlayingTime.ToString();
    }
    public void ShowTime() // method for clicking on playing speed button on game screen 
    {
        playingTimeText.text = PlayingTime.ToString();
        TimeSlider.value = PlayingTime; // you use the speed value here

    }
    public void ChangeTime() //method for slider on game screen, so you see that you can still change the value after transfer between screens
    {
        PlayingTime = TimeSlider.value; // change to the new value from game screen slider
        playingTimeText.text = TimeSlider.value.ToString(); //show updated value

    }
}
