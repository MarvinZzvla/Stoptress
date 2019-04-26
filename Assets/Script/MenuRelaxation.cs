using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuRelaxation : MonoBehaviour {

	public void DeepSleep()
    {
        SceneManager.LoadScene("DeepSleep");
    }

    public void Asmr()
    {
        SceneManager.LoadScene("Asmr");
    }

}
