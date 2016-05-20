using UnityEngine;
using System.Collections;

public class GameOverButtonControl : MonoBehaviour {

	public void MainMenuButton()
    {
        Application.LoadLevel("menuScene");
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
