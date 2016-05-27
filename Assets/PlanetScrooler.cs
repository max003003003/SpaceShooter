using UnityEngine;
using System.Collections;

public class PlanetScrooler : MonoBehaviour {
    public float speed;
    public float Z;

    private Vector3 start;
	// Use this for initialization
	void Start () {
        start = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        float newposition = Mathf.Repeat(Time.time * speed, Z);
        transform.position = start + Vector3.forward * newposition;
	}
}
