using UnityEngine;
using System.Collections;

public class GameAllControl : MonoBehaviour {
    public static int second;
    public static int minute;
    public static bool MarchClear;
    public static bool SaternClear;
    public static bool Jupiterclear;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(minute==3)
        {
            minute = 0;
            second = 0;
        }
	}
             
    public static void setZero()
    {
        second = 0;
        minute = 0;
    }
}
