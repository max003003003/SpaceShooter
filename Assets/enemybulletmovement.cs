using UnityEngine;
using System.Collections;

public class enemybulletmovement : MonoBehaviour
{
    public float speed;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("shoot", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(new Vector3(0, speed, 0));
    }

}
