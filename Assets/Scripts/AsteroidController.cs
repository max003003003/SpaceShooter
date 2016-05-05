using UnityEngine;
using System.Collections;

public class AsteroidController : MonoBehaviour {

    public float speed;
	
	// Update is called once per frame
    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * Random.Range(-50, 50);
        Vector3 movement = new Vector3(0.0f, 0.0f, Random.Range(-20.0f, -5.0f));
        GetComponent<Rigidbody>().velocity = movement * speed;
    }
	 
}
