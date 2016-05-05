using UnityEngine;
using System.Collections;

public class Orbitcontroller : MonoBehaviour {

    public GameObject myOrbit;
    GameObject myOrbitPrefabs;
    public Rigidbody rigid;
   public GameObject container;
    void Update()
    {

        if (Input.GetKey(KeyCode.F))
        {
            myOrbitPrefabs = Instantiate(myOrbit, transform.position, Quaternion.identity) as GameObject;
            //myOrbitPrefabs = (GameObject)Instantiate(myOrbit);       

            myOrbitPrefabs.transform.position = new Vector3(Random.Range(-10,10),Random.Range(-10,10), 500);            
            myOrbitPrefabs.transform.SetParent(container.transform, false);
            Destroy(myOrbitPrefabs, 15);
        }
    }
}
