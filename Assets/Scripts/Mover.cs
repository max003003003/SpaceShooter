using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    // Use this for initialization
    public float speed;
    public float destroyTime;


    void Start () {
         
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
        Destroy(this.gameObject, destroyTime);

    }
	
	
	void Update () {
	
	}
}
