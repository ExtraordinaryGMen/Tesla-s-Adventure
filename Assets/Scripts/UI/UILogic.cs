using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UILogic : MonoBehaviour {
	public void newGame()
    {
        SceneManager.LoadScene(1);
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
