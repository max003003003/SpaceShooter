using UnityEngine;
using System.Collections;

public class ItemControl : MonoBehaviour {

    // Use this for initialization
    public  float speed;
    public float timeEffect;
    
	void Start () {
        Invoke("SpawnObject", timeEffect);
        
    }
	
	// Update is called once per frame
	void Update () {
	  gameObject.transform.transform.Translate( 0,0,speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(this.gameObject.tag=="Speed")
            {
                 
                AsteroidPrefabsController instanceOfB = GameObject.Find("AsteroidCon").GetComponent<AsteroidPrefabsController>();           
                GameControl.slow = true;
            }
           else  if (this.gameObject.tag == "LifeLevel")
            {
               
                GameControl.life++;
                Destroy(gameObject);
            }
            else {
                gameObject.SetActive(false);
                GameControl.fire3Way = true;
            }


        }
        else { return; }

    }
    void SpawnObject()//fire3object time
    {
        if(this.gameObject.tag== "Item")
             GameControl.fire3Way = false;

        if (this.gameObject.tag == "Speed")
            GameControl.slow = false;

        Destroy(gameObject);
    }
}
