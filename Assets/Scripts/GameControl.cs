using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {
    public static string scene;
    public static int score;
    public static int life = 2;
    public static bool fire3Way = false;
    public static bool gameOver = false;
    public static bool die = false;
    public static bool slow = false;
    public static bool fire5Way = false;
    public static int enemylife = 300;
 
    
    void Start()
    {
        scene = Application.loadedLevelName;
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
