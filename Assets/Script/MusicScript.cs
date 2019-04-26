using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicScript : MonoBehaviour {
    AudioSource audio;
    public AudioClip advice;
    public Sprite playBtn, pauseBtn;
    private AudioClip Music;
    // Use this for initialization
    bool isPlaying = true;
    int a = 1;

    void Start() {
        audio = GetComponent<AudioSource>();
        Music = audio.clip;
        audio.clip = advice;
        audio.Play();
        Invoke("UpdateClip", 4.8f);
        Debug.Log(Music.length);
        Invoke("CloseApp", Music.length + 300f);
      

    }

    void UpdateClip()
    {
        audio.Stop();
        audio.clip = Music;
        if(isPlaying)
            audio.Play();
    }

    public void MusicPlay()
    {
        if (isPlaying)
        {
            audio.Pause();
            isPlaying = audio.isPlaying;
            GameObject.Find("Play").GetComponent<Image>().sprite = playBtn;
            a = 0;
            
            
        }
        else
        {
            audio.Play();
            isPlaying = audio.isPlaying;
            GameObject.Find("Play").GetComponent<Image>().sprite = pauseBtn;
            
            
        }
    }

    void CloseApp()
    {
        Screen.sleepTimeout = SleepTimeout.SystemSetting;
        
    }

  
}
