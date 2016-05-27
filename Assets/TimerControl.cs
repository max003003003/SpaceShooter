using UnityEngine;
using System.Collections;

public class TimerControl : MonoBehaviour {
    public string nextscene;
    public GameObject scenechange;
    // Use this for initialization
    public int maxscore;
	void Start () {
  
	}
	
	// Update is called once per frame
	void Update () {

        if (GameControl.getScene() == "Main")
        {

            if (GameControl.timeOut && GameControl.score >= 600)
            {
                GameControl.gameOver = false;
                GameAllControl.MarchClear = true;

                changescenecontrol.nextscene = "Satern";
                GameAllControl.setZero();
                Instantiate(scenechange, gameObject.transform.position, gameObject.transform.rotation);

            }
            else if (GameControl.timeOut && GameControl.score < 600)
            {
                GameControl.gameOver = true;
                GameControl.timeOut = false;
                GameControl.die = false;

                Instantiate(scenechange, gameObject.transform.position, gameObject.transform.rotation);
            }

        }
        else if (GameControl.getScene() == "Satern")
        {
             
            if (GameControl.timeOut && GameControl.score >= 1400)
            {
                GameControl.gameOver = false;
                GameAllControl.MarchClear = true;

                changescenecontrol.nextscene = "Jupiter";
                GameAllControl.setZero();
                Instantiate(scenechange, gameObject.transform.position, gameObject.transform.rotation);

            }
            else if (GameControl.timeOut && GameControl.score < 1400)
            {
                GameControl.gameOver = true;
                GameControl.timeOut = false;
                GameControl.die = false;

                Instantiate(scenechange, gameObject.transform.position, gameObject.transform.rotation);
            }

        }
        /*if(GameControl.timeOut&&GameControl.life>0)
        {
             
            GameControl.timeOut = false;
            GameControl.die = true;
            changescenecontrol.life = 1;
            Instantiate(scenechange, gameObject.transform.position, gameObject.transform.rotation);

        }else if(GameControl.timeOut&&GameControl.life<1)
        {

            GameControl.timeOut = false;
            GameControl.gameOver = true;
            
            Instantiate(scenechange, gameObject.transform.position, gameObject.transform.rotation);
        }  */
	}
}
