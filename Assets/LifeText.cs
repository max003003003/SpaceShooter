using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LifeText : MonoBehaviour {
    Text text;
	// Use this for initialization
    void Awake()
    {
        text = GetComponent<Text>();
    }
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        text.text= "Life "+GameControl.life;
	}
}
