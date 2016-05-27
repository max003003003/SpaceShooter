using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {
    public GameObject explosion;
    public GameObject playerExploeion;
    public GameObject scenecontrol;//change scene object

    void Start()
    {
     
    }
  

    void OnTriggerEnter(Collider other) {
        Debug.Log(GameControl.timeOut);
      
            if (other.tag == "Back")
            {
                if (gameObject.tag == "Asteroid")
                {
                   
                    AsteroidPrefabsController instanceOfB = GameObject.Find("AsteroidCon").GetComponent<AsteroidPrefabsController>();
                    instanceOfB.destroy(gameObject);
                }
                Destroy(gameObject);


            }
            else if (other.tag != "Asteroid" && other.tag != "Item" && other.tag != "LifeLevel" && other.tag != "Speed")
            {
            if (other.tag == "Player")
            {
                       GameControl.life--;
                       Instantiate(playerExploeion, transform.position, transform.rotation);
         
                        if (GameControl.life < 1)
                        {
                            Invoke("SpawnObject", 2);
                            //Application.LoadLevel("GameOver");
                            GameControl.gameOver = true;
                            GameControl.timeOut = false;

                            Instantiate(scenecontrol, transform.position, transform.rotation);

                        }
                        else
                        {
                                //Application.LoadLevel("Main");
                                if (GameControl.getScene() == "Main" && GameControl.score >= 600)
                                {
                                     GameAllControl.MarchClear = true;
                                   GameAllControl.setZero();
                                    changescenecontrol.changeSceneNow("Satern");
                                } else if (GameControl.getScene() == "Satern" && GameControl.score >= 1400)
                                    {
                                        GameAllControl.SaternClear = true;
                                        GameAllControl.setZero();
                                        changescenecontrol.changeSceneNow("Jupiter");
                                    }
                                else {

                                    GameControl.die = true;
                                    GameControl.timeOut = false;

                                    Instantiate(scenecontrol, transform.position, transform.rotation);
                                    //Destroy(scenecontrol, 3f);
                                }

                        }



                }
                else {

                             Instantiate(explosion, transform.position, transform.rotation);
                             GameControl.score += 10;
               }
                            Debug.Log("" + other.tag);
                            Destroy(other.gameObject);


                            Destroy(gameObject);
             
            }
        }
    


    

}
