using UnityEngine;
using System.Collections;

public class AsteroidPrefabsController : MonoBehaviour {
    public GameObject AsteroiPrefab;
    public GameObject AsteroiPrefab2;
    public GameObject AsteroiPrefab3;
    GameObject AsteroidClone;
    GameObject AsteroidClone2;
    GameObject AsteroidClone3;
    public GameObject container;
    public float rate;
    private float nextFire = 0.0F;
    public float xMin; 
    public float xMax;
    public float yMin;
    public float yMax;
    public float z;
    public float destroyTime;

    // Use this for initialization

    
 
    // Update is called once per frame
    void Update () {
       
        if ( Time.time > nextFire)
        {
            nextFire = Time.time + rate;
            AsteroidClone = (GameObject)Instantiate(AsteroiPrefab, new Vector3(Random.Range(xMin,xMax), Random.Range(yMin, yMax), z), Quaternion.identity);
            float scale = Random.Range(-0.1f, 3);
            AsteroidClone.transform.SetParent(container.transform, false);
            AsteroidClone.transform.localScale += new Vector3(scale, scale, scale);
 
            scale = Random.Range(-0.2f, 4f);
            AsteroidClone2 = (GameObject)Instantiate(AsteroiPrefab2, new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), z), Quaternion.identity);
            AsteroidClone2.transform.localScale += new Vector3(scale, scale, scale);
            AsteroidClone2.transform.SetParent(container.transform, false);
           
            AsteroidClone3 = (GameObject)Instantiate(AsteroiPrefab3, new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), z), Quaternion.identity);
             scale = Random.Range(0.5f, 5);
            AsteroidClone3.transform.localScale += new Vector3(scale,scale,scale);
            AsteroidClone3.transform.SetParent(container.transform, false);
            Destroy(AsteroidClone, destroyTime);
            Destroy(AsteroidClone2, destroyTime);
            Destroy(AsteroidClone3, destroyTime);
          
        }

    }



}
