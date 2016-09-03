using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {
    private bool isPause = false;
    public GameObject pauseScreen;
    // Use this for initialization
    void Start () {
        pauseScreen.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPause = !isPause;
            if (isPause)
            {
                pauseScreen.SetActive(true); 
                Time.timeScale = 0;
            }
            else
            {
                pauseScreen.SetActive(false);
                Time.timeScale = 1;
            }
        }
	}
}
