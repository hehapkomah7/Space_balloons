using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float TimerValue = 99;
    public TMP_Text Timer_txt;
    public TouchManager Tm;

    void Update()
    {       
        TimerValue -= Time.deltaTime;
        Timer_txt.text = TimerValue.ToString("00");

        if (TimerValue <= 0)
        {
            Time.timeScale = 0f;
            Tm.audio.clip = Tm.Gameover_sound;
            Tm.audio.Play();
            Tm.Gameover.SetActive(true);
            //Tm.CalculateHighScore(Tm.score);
        }
    }
}
