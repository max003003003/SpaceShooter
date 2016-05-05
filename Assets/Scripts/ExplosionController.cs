using UnityEngine;
using System.Collections;

public class ExplosionController : MonoBehaviour {
    public float destroyTime;
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, destroyTime);
	}
	
 
}
