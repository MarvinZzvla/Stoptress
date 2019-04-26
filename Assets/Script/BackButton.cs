using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour {
    // Update is called once per frame
    public string sceneName;
    
 

    private void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        
    }
    void Update () {
		if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Q))
        {
            if (sceneName == "")
            {
                Application.Quit();
            }
            else
            {
                SceneManager.LoadScene(sceneName);
            }
            
        }
	}

    private void OnApplicationPause(bool pause)
    {
       
    }
}
