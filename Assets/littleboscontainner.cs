using UnityEngine;
using System.Collections;

public class littleboscontainner : MonoBehaviour {
    public GameObject littlebosprefab;
    public GameObject containner;
    public static int enemycount;
	// Use this for initialization
	void Start () {
        enemycount = 0;
	}
	
	// Update is called once per frame
	void Update () {
	    if(enemycount<3)
        {
            Instantiate(littlebosprefab, containner.transform.position, containner.transform.rotation);
            enemycount++;
        }
	}
}
