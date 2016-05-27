using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class clock : MonoBehaviour {
    Text text;
    int second;
    int minute;
    // Use this for initialization
    void Awake()
    {
        text = GetComponent<Text>();
       
    }

    void Start () {
        InvokeRepeating("Trig",1.0f,1.0f);
        
    }
	
	// Update is called once per frame
	void Update () {
        if (minute == 4)
        {
            GameControl.timeOut = true;
            GameControl.die = true;

        }

        if (second < 10)
            text.text = "0" + minute + " : 0" + second;
        else
            text.text = "0" + minute + " :" + second;

        if (second>=60)
        {
            minute++;
            second = 0;
        }
       
	}
    void Trig()
    {
        second++;
    }
}
