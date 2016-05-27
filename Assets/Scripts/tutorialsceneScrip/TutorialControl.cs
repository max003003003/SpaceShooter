using UnityEngine;
using System.Collections;

public class TutorialControl : MonoBehaviour {
    public static string scene;
    public static int score;
    public static int life = 3;
    public static bool fire3Way = false;
    public static bool gameOver = false;
    public static bool die = false;
    public static bool slow = false;
    public static bool fire5Way = false;
    public static int textstate = 1;
    public static int maxscoreenemy = 50;
    public static bool timeOut = false;

    void Start()
    {
        scene = Application.loadedLevelName;
        
    }
    void Update()
    {
        
        if(textstate==2)
        {
           
        }

    }
    public static int getScore()
    {
        return GameControl.score;
    }
    public static void reset()
    {
        score = 0;
        life = 3;
        fire3Way = false;
        gameOver = false;
        die = false;
        slow = false;
        fire5Way = false;

    }
    public static string getScene()
    {
        return scene;

    }

}
