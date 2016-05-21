using UnityEngine;
using System.Collections;

public class BulletControl : MonoBehaviour {

    // Use this for initialization
    public float speed;
 
    void Start()
    {
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.transform.Translate(0, 0, speed);
    }

}
