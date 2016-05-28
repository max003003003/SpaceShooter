using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class GameOverText : MonoBehaviour {
    Text text;
	// Use this for initialization
    void Awake()
    {
        text = GetComponent<Text>();
    }
	void Start () {
        text.text += " Your Score is " + GameControl.score;
    }
	
	// Update is called once per frame
	void Update () {
        if(GameControl.getScene()=="Endless")
        {
            text.text = "Game Over";
            text.text += " \nYour Score is \n" + GameControl.score;

            text.text += "\n Time ";
            if(GameAllControl.minute < 10)
            {
                text.text += "0" + GameAllControl.minute;
            }
            else
            {
                text.text += GameAllControl.minute;
            }
            text.text += ":";
            if (GameAllControl.second < 10)
            {
                text.text += "0" + GameAllControl.second;
            }
            else
            {
                text.text += GameAllControl.second;
            }
        }
        else if (GameControl.win)
        {
            text.text = "You win";
            text.text += " \nYour Score is \n" + GameControl.score;
            GameControl.win = false;
        }
    }
}
