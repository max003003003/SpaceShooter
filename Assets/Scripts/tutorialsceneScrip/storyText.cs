using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class storyText : MonoBehaviour {
    Text text;
    string fText = "Welcome to Back to the earth \nLeft click for shoot \nw/s key for move up or down \na/d key for move left or right \n\n Let's shoot";
    int state;
    public int i=0;
    public float rate;
   
    void Awake()
    {

        text = GetComponent<Text>();
    }
    // Use this for initialization
    void Start () {
         
        InvokeRepeating( "print",1, rate);
    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public  void setText(string text)
    {
       if(text != null)
        {
            fText = text;
            TutorialControl.textstate = 2;
        }
    }
    void print()
    {
        i++;
        if (i >= fText.Length)
        {
            text.text = fText;
            TutorialControl.textstate = 2;

        }
        else
            text.text = fText.Substring(0, i);
        
    }
}
