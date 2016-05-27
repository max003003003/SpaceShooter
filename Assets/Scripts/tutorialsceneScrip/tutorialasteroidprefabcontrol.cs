using UnityEngine;
using System.Collections;

public class tutorialasteroidprefabcontrol : MonoBehaviour
{

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
    private ArrayList Storage = new ArrayList();
    // declaration

    // Use this for initialization



    // Update is called once per frame
    void Update()
    {

        if (TutorialControl.textstate == 2)
        {

        }
    }

     


}
