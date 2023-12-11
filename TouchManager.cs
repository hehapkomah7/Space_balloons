using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    public float laserLength = .3f;

    public int score = 0;
    public TMP_Text Score_txt;
    public GameObject Gameover;  
    public AudioSource audio;
    public AudioClip Gameover_sound, Pop;
    public TMP_Text Gameover_H_Score_txt;
    int Highscore = 0;
    public ScoreManager ScoreManager;

    void Update()
    {
        if (Time.timeScale == 0)
        {
            return;
        }


        if (!Input.GetMouseButtonDown(0))
        {
            return;
        }

        RaycastHit2D Ray = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.up * laserLength);
        Debug.DrawRay(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.up * laserLength, Color.red);

        if (Ray.collider == null)
        {
            return;
        }

        if (Ray.collider.gameObject.CompareTag("Disable_click"))
        {
            return;
        }

        if (Ray.collider.gameObject.CompareTag("Balloon_normal"))
        {
            audio.clip = Pop;
            audio.Play();

            score++;
            Score_txt.text = "Score : " + score;
            Ray.collider.gameObject.GetComponent<Animator>().SetBool("Destroy", true);
            Destroy(Ray.collider.gameObject, .2f);

            return;
        }

        if (Ray.collider.gameObject.CompareTag("Balloon_good"))
        {
            audio.clip = Pop;
            audio.Play();

            score += 3;
            Score_txt.text = "Score : " + score;
            Ray.collider.gameObject.GetComponent<Animator>().SetBool("Destroy", true);
            Destroy(Ray.collider.gameObject, .2f);

            return;
        }

        if (Ray.collider.gameObject.CompareTag("Balloon_bad"))
        {
            audio.clip = Pop;
            audio.Play();

            score -= 3;
            Score_txt.text = "Score : " + score;
            Ray.collider.gameObject.GetComponent<Animator>().SetBool("Destroy", true);
            Destroy(Ray.collider.gameObject, .2f);

            return;
        }

        if (Ray.collider.gameObject.CompareTag("Balloon_question"))
        {
            audio.clip = Pop;
            audio.Play();

            score += Random.Range(-3, 3);
            Score_txt.text = "Score : " + score;
            Ray.collider.gameObject.GetComponent<Animator>().SetBool("Destroy", true);
            Destroy(Ray.collider.gameObject, .2f);

            return;
        }

        if (Ray.collider.gameObject.CompareTag("Balloon_end"))
        {
            CalculateHighScore(score);
            Gameover.SetActive(true);

            audio.clip = Gameover_sound;
            audio.Play();

            Time.timeScale = 0;
            Ray.collider.gameObject.GetComponent<Animator>().SetBool("Destroy", true);
            Destroy(Ray.collider.gameObject, .2f);

            return;
        }        
    }

    public void CalculateHighScore(int scr)
    {
        //Highscore = PlayerPrefs.GetInt("Hscore", 0);
        //if(scr >= Highscore)
        //{
           // Highscore = scr;
           // PlayerPrefs.SetInt("Hscore", Highscore);
       //}

        //Gameover_H_Score_txt.text = "High Score: " + PlayerPrefs.GetInt("Hscore", 0);

        string Player_name = PlayerPrefs.GetString("name", "none");
        Score sc = new Score(Player_name, score);
        ScoreManager.AddScore(sc);
    }




}
