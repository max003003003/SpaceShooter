using UnityEngine;
using System.Collections;

public class skipButton : MonoBehaviour {


    public void SkipScene()
    {
        Application.LoadLevel("TutorialScene");
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
