using UnityEngine;
 
using System.Collections;

public class changescenecontrol : MonoBehaviour {

    // Use this for initialization
    public float timefordiechangescene;
    public float timeforgameoverchangescene;
    public static string nextscene;
     
    
    void Start () {
       

        if (GameControl.die)
        {
            Invoke("changeScene", timefordiechangescene);
        }
        else if (GameControl.gameOver)
            Invoke("changeScene", timeforgameoverchangescene);


        gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	    if(GameControl.timeOut)
        {
            timefordiechangescene = 0;
        }
	}

   public static void changeSceneNow(string name)
    {
        Application.LoadLevel(name);
    }
    void changeScene()//fire3object time
    {
        GameControl.tempSecond = 0;
        GameControl.tempMinute = 0;
        if (GameControl.timeOut)
        {
            GameControl.die = false;
            GameControl.timeOut = false;
            Application.LoadLevel(nextscene);
            nextscene = "";
        }
        
       else if (GameControl.die)
        {
            GameControl.die = false;
                GameControl.timeOut = false;
                GameControl.gameOver = false;
                Debug.Log(GameControl.getScene());
                Application.LoadLevel(GameControl.getScene());
               
            
        }
        else if(GameControl.gameOver){
            GameControl.gameOver = false;
            GameControl.timeOut = false;
            Application.LoadLevel("GameOver");
             
        }
    }
  
}
