using UnityEngine;
using System.Collections;

public class ItemControl : MonoBehaviour {

    // Use this for initialization
    public float speed;
    public float timeEffect;
	void Start () {
        Invoke("SpawnObject", timeEffect);
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (this.gameObject.tag == "LifeLevel")
            {
                GameControl.life++;
            }
            else {
                gameObject.SetActive(false);
                GameControl.fire3Way = true;
            }
        }
        
    }
    void SpawnObject()//fire3object time
    {
        if(this.gameObject.tag== "Item")
             GameControl.fire3Way = false;


        Destroy(gameObject);
    }
}
