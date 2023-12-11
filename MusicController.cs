using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource Audio;

    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        Audio.volume = PlayerPrefs.GetFloat("Music", 1);
        
        if(Time.timeScale == 0)
        {
            Audio.mute = true;
        }

        else
        {
            Audio.mute = false;
        }
    }
}
