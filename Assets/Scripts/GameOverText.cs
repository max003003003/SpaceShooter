using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class GameOverText : MonoBehaviour {
    Text text;
	// Use this for initialization
    void Awake()
    {
        text = GetComponent<Text>();
    }
	void Start () {
        text.text += " Your Score is " + GameControl.score;
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
