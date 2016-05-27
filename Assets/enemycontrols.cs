using UnityEngine;
using System.Collections;

public class enemycontrols : MonoBehaviour {
    public GameObject enemy;
    public GameObject container;
    public int maxenemy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	   /* if(GameControl.enemy)
        {
            GameControl.enemy = false;
            GameControl.slow = true;
            for(int i=0;i<maxenemy;i++)
            {
                Instantiate(enemy, container.transform.position, container.transform.rotation);
            }
       
        } */
	}
}
