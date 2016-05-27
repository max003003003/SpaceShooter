using UnityEngine;
using System.Collections;

public class bulletenemycontrol : MonoBehaviour
{

    public float speed;
    public GameObject scenecontrol;
    public GameObject explosion;

    void Start()
    {
        Destroy(gameObject,5);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.transform.Translate(0, 0, speed);
    }

    void OnTriggerEnter(Collider other)
    {
      
           
       
        if (other.tag == "Player")
        {
            GameControl.life--;
            Instantiate(explosion, transform.position, transform.rotation);
            if (GameControl.life < 1)
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
            Destroy(other.gameObject);

        }
    }
}
