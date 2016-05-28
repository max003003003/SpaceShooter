using UnityEngine;
using System.Collections;

public class MenuControl : MonoBehaviour {
   public void loadNewScene()
    {
        Application.LoadLevel("Main");
    }
    public void loadJupiter()
    {
        Application.LoadLevel("Satern");
    }
    public void loadSatern()
    {
        Application.LoadLevel("Jupiter");
    }
    public void exitGame()
    {
        Application.Quit(); 
    }
    public void tutorial()
    {
        Application.LoadLevel("TutorialExplainScene");
    }
    public void endless()
    {
        Application.LoadLevel("Endless");
    }
}
