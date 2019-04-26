using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOption : MonoBehaviour {

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            Invoke("AbrirMenu", 0.5f);
        }
    }

    public void Breathing()
    {
        SceneManager.LoadScene("Breathing");
    }

    public void OpenOptions()
    {
        GetComponent<Animator>().Play("Menu");
        GameObject.Find("CanvasApp").GetComponent<Canvas>().sortingOrder = 0;
    }

    public void Nature() {
        SceneManager.LoadScene("Nature");
    }

    public void Relaxation()
    {
        SceneManager.LoadScene("Relaxation");
    }

    void AbrirMenu()
    {
        GetComponent<Animator>().Play("Menu");
    }

    public void Information()
    {
        SceneManager.LoadScene("Information");
    }
}
