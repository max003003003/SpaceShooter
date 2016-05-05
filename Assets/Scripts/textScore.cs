using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class textScore : MonoBehaviour {

    // Use this for initialization
    Text text;
    void Awake()
    {
        text = GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {
        text.text = "Score: " + GameControl.score;
	}
}
