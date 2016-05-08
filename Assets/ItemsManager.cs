using UnityEngine;
using System.Collections;

public class ItemsManager : MonoBehaviour {
    public GameObject fire3wayPrefab;
    public GameObject ItemContainercontainer;
    public GameObject LifePrefab;
    public float fire3wayitemTime;
    public float lifeitemTime;

    void Start()
    {
        InvokeRepeating("fire3wayDrop", 2, fire3wayitemTime);
        InvokeRepeating("lifeLevel", 5, lifeitemTime);
    }
    
    void fire3wayDrop()
    {
        Instantiate(fire3wayPrefab, ItemContainercontainer.transform.position,ItemContainercontainer.transform.rotation);
    }
    void lifeLevel()
    {
        Instantiate(LifePrefab, ItemContainercontainer.transform.position, ItemContainercontainer.transform.rotation);
    }
    
}
