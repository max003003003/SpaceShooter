﻿using UnityEngine;
using System.Collections;

public class ItemsManager : MonoBehaviour {
    public GameObject fire3wayPrefab;
    public GameObject ItemContainercontainer;
    public GameObject LifePrefab;
    public GameObject AsteroiSpeed;
    public float fire3wayitemTime;
    public float lifeitemTime;
    public float asteroidTime;

    void Start()
    {
       
        InvokeRepeating("fire3wayDrop", 15, fire3wayitemTime);
        InvokeRepeating("lifeLevel", 50, lifeitemTime);
        InvokeRepeating("slowSpeed", 10, asteroidTime);

    }
    
    void fire3wayDrop()
    {
        Instantiate(fire3wayPrefab, ItemContainercontainer.transform.position,ItemContainercontainer.transform.rotation);
    }
    void lifeLevel()
    {
        Instantiate(LifePrefab, ItemContainercontainer.transform.position, ItemContainercontainer.transform.rotation);
    }
    void slowSpeed()
    {
        Instantiate(AsteroiSpeed, ItemContainercontainer.transform.position, ItemContainercontainer.transform.rotation);
    }
    
}
