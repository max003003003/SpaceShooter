using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DieText : MonoBehaviour {
    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(GameControl.gameOver&&GameControl.win)
        {
            text.text = "You win";
        }else if(GameControl.die)
        {
            text.text = "You Die";
        }else if(GameControl.gameOver)
                {
            text.text = "Game Over";
            
        }
    }
}
