using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNature : MonoBehaviour {

	public void Rain()
    {
        SceneManager.LoadScene("Rain");
    }

    public void Forests()
    {
        SceneManager.LoadScene("Forests");
    }

    public void Instrumental()
    {
        SceneManager.LoadScene("Instrumental");
    }
}
