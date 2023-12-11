using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    public Slider SoundSlider;
    public Slider MusicSlider;
    public GameObject SoundObject;

    void Start()
    {
        SoundSlider.value = PlayerPrefs.GetFloat("Sound", 0);
        MusicSlider.value = PlayerPrefs.GetFloat("Music", 0);
    }

    void Update()
    {   
        SoundObject.GetComponent<AudioSource>().volume = SoundSlider.value;
        PlayerPrefs.SetFloat("Sound", SoundSlider.value);
        PlayerPrefs.SetFloat("Music", MusicSlider.value);
    }
}
