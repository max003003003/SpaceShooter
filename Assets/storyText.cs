using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class storyText : MonoBehaviour {
    Text text;
    public string fText;
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
        }
    }
    void print()
    {
        i++;
        if (i >= fText.Length)
            text.text = "";
        else 
            text.text = fText.Substring(0, i);
        
    }
}
