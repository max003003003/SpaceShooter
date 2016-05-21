using UnityEngine;
using System.Collections;

public class GameOverButtonControl : MonoBehaviour {

	public void MainMenuButton()
    {
        Application.LoadLevel("menuScene");
        GameControl.reset();
    }
    public void ExitButton()
    {
        GameControl.reset();
        Application.Quit();
    }
}
