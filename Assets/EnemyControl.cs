using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class EnemyControl : MonoBehaviour {
    public float maxX;
    public float minX;
    public float maxY ;
    public float minY ;
    public GameObject explosion;
  //  public Text text;

    private float tChange = 0; // force new direction in the first Update
    private float randomX ;
    private float randomY ;
    public float moveSpeed;
    public GameObject bullet;
    public GameObject spawn;
    public int enemylife = 1000;
    void Start()
    {
        InvokeRepeating("shoot",2.5f, 0.5f);
       
        //text.text = "" + GameControl.enemylife;
    }
 void Update()
    {
        Debug.Log(littleboscontainner.enemycount);
        
        // change to random direction at random intervals
        if (Time.time >= tChange)
        {
            randomX = Random.Range(-2.0f, 2.0f); // with float parameters, a random float
            randomY = Random.Range(-2.0f, 2.0f); //  between -2.0 and 2.0 is returned
                                               // set a random interval between 0.5 and 1.5
            tChange = Time.time + Random.Range(0.5f, 1.5f);
        }
        transform.Translate(new Vector3(randomX, randomY, 0) * moveSpeed * Time.deltaTime);
        // if object reached any border, revert the appropriate direction
        if (transform.position.x >= maxX || transform.position.x <= minX)
        {
            randomX = -randomX;
        }
        if (transform.position.y >= maxY || transform.position.y <= minY)
        {
            randomY = -randomY;
        }
        // make sure the position is inside the borders
        gameObject.transform.position = new Vector3(Mathf.Clamp(gameObject.transform.position.x, minX, maxX), Mathf.Clamp(transform.position.y, minY, maxY), gameObject.transform.position.z);
       
        
    }
    void shoot()
    {
       GameObject clone= Instantiate( bullet,new Vector3(gameObject.transform.position.x,gameObject.transform.position.y+2.95f,gameObject.transform.position.z-5.0f), gameObject.transform.rotation) as GameObject;
        clone.transform.SetParent(spawn.transform);
    }
    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "playerbullet" )
        {
            Debug.Log(enemylife);
            if ( enemylife <= 0)
            {
                Debug.Log(littleboscontainner.enemycount);
                CancelInvoke();
                littleboscontainner.enemycount -= 1;
                Destroy(gameObject);
             
            }
            else {
                Instantiate(explosion, new Vector3( other.gameObject.transform.position.x,other.gameObject.transform.position.y ,other.gameObject.transform.position.z+2), gameObject.transform.rotation);
                enemylife -= 50;
                GameControl.score += 50;
            }
        }
     }
}


