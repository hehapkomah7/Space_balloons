using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource Audio;

    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        Audio.volume = PlayerPrefs.GetFloat("Sound", 1);
    }
}
