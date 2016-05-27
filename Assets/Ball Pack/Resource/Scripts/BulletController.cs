using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {


    public GameObject myBullet;
    GameObject myBulletPrefabs;   
    public GameObject container;
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.F))
        {
           //myBulletPrefabs = (GameObject)Instantiate(prefabcoin);
            myBulletPrefabs = (GameObject)Instantiate(myBullet,myBullet.transform.position,myBullet.transform.rotation);
            myBulletPrefabs.transform.position = new Vector3(0, 0, 200);
            myBulletPrefabs.transform.SetParent(container.transform, false);
            Destroy(myBulletPrefabs, 15);
        }
    }
}
