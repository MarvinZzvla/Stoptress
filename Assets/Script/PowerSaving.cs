using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerSaving : MonoBehaviour {
    bool isBlack = false;
	// Use this for initialization
	void Start () {
        Invoke("ChangeBlack", 5f);
	}


    public void ChangeScreen()
    {
        if (isBlack)
        {
            GetComponent<Image>().color = new Color(0f, 0f, 0f, 0f);
            isBlack = false;
            GameObject.Find("CanvasScreen").GetComponent<Canvas>().sortingOrder = 0;
            Invoke("ChangeBlack", 6f);
        }        

    }

    void ChangeBlack()
    {
        GetComponent<Image>().color = new Color(0f, 0f, 0f, 1f);
        isBlack = true;
        GameObject.Find("CanvasScreen").GetComponent<Canvas>().sortingOrder = 2;
    }
}
