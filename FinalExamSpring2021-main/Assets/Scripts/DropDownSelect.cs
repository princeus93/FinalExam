using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownSelect : MonoBehaviour
{
    // this script is attached to the manager, but could be attached to any gameobject that has an update method.
    public Dropdown MyDropDown;
    public Text MyChoice;

    // Update is called once per frame
    public void ShowChoice()
    {
        switch (MyDropDown.value)
        {
            case 1:
                MyChoice.text = "1";
                break;
            case 2:
                MyChoice.text = "2";
                break;
            case 3:
                MyChoice.text = "3";
                break;
            case 4:
                MyChoice.text = "4";
                break;
            case 5:
                MyChoice.text = "5";
                break;
            case 6:
                MyChoice.text = "6";
                break;
            case 7:
                MyChoice.text = "7";
                break;
            case 8:
                MyChoice.text = "8";
                break;
            case 9:
                MyChoice.text = "9";
                break;
            default:
                MyChoice.text = "0";
                break;
        }
    }
}
