using UnityEngine;
 
using System.Collections;

public class changescenecontrol : MonoBehaviour {

    // Use this for initialization
    public float timefordiechangescene;
    public float timeforgameoverchangescene;
   

    void Start () {
        if (GameControl.die)
            Invoke("changeScene", timefordiechangescene);
        else if (GameControl.gameOver)
            Invoke("changeScene", timeforgameoverchangescene);


        gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    
    void changeScene()//fire3object time
    {
        if (GameControl.die)
        {
            Application.LoadLevel("Main");
            GameControl.die = false;
        }
        else {
            Application.LoadLevel("GameOver");
            GameControl.gameOver = false;
        }
    }
  
}
