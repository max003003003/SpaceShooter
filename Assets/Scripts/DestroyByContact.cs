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
        if (other.tag == "Back")
        {
            Destroy( gameObject);

        }else if (other.tag != "Asteroid"&&other.tag!="Item"&&other.tag!="LifeLevel")
        {
            if (other.tag == "Player")
            {
                GameControl.life--;
                Instantiate(playerExploeion, transform.position, transform.rotation);
                if(GameControl.life<1)
                {
                    Invoke("SpawnObject", 2);
                    //Application.LoadLevel("GameOver");
                    GameControl.gameOver = true;
                    Instantiate(scenecontrol, transform.position, transform.rotation);

                }
                else
                {
                    //Application.LoadLevel("Main");
                    GameControl.die = true;
                    Instantiate(scenecontrol, transform.position, transform.rotation);
                    //Destroy(scenecontrol, 3f);
                    

                }

               

            }
            else {

                Instantiate(explosion, transform.position, transform.rotation);
                GameControl.score += 10;

            }

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }


    

}
