using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {
    public GameObject explosion;
    public GameObject playerExploeion;
    void Start()
    {
      
    }
    
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Back")
        {
            Destroy( gameObject);

        }else if (other.tag != "Asteroid"&&other.tag!="Item")
        {
            if (other.tag == "Player")
            {
                GameControl.life--;
                Instantiate(playerExploeion, transform.position, transform.rotation);
                if(GameControl.life<1)
                {

                    Application.LoadLevel("GameOver");
                    
                }
                else
                {
                    Application.LoadLevel("Main");
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
