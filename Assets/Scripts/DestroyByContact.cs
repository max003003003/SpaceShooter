using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {
    public GameObject explosion;
    public GameObject playerExploeion;

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Back")
        {
            Destroy( gameObject);

        }else if (other.tag != "Asteroid")
        {
            if (other.tag == "Player")
            {
                Instantiate(playerExploeion, transform.position, transform.rotation);
                
                Application.LoadLevel("GameOver");

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
