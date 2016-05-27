using UnityEngine;
using System.Collections;

public class MenuControl : MonoBehaviour {
   public void loadNewScene()
    {
        Application.LoadLevel("Main");
    }
    public void exitGame()
    {
        Application.Quit(); 
    }
    public void tutorial()
    {
        Application.LoadLevel("TutorialExplainScene");
    }
}
