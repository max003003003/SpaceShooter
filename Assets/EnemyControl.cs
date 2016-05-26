using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {
    public float maxX;
    public float minX;
    public float maxY ;
    public float minY ;

    private float tChange = 0; // force new direction in the first Update
    private float randomX ;
    private float randomY ;
    public float moveSpeed;
    public GameObject bullet;
    void Start()
    {
        InvokeRepeating("shoot", 1f, 0.5f);
    }
 void Update()
    {
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
        Instantiate( bullet,new Vector3(gameObject.transform.position.x,gameObject.transform.position.y+2.95f,gameObject.transform.position.z), gameObject.transform.rotation);
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("" + other.tag);
    }
}


