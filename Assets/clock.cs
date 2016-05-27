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
         
        

        if (GameAllControl.minute == 3)
        {
            GameControl.timeOut = true;
            GameControl.die = true;

        }

        if (GameAllControl.second < 10)
            text.text = "0" + GameAllControl.minute + " : 0" + GameAllControl.second;
        else
            text.text = "0" + GameAllControl.minute + " :" + GameAllControl.second;

        if (GameAllControl.second >=60)
        {
            GameAllControl.minute++;
            GameAllControl.second = 0;
        }
       
	}
    void Trig()
    {
        GameAllControl.second++;
    }
}
