using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawnerHard : MonoBehaviour
{
    public float MinX, MaxX;
    public GameObject[] BalloonsHard;

    public float MaxTime;
    float CurrentTime = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime += Time.deltaTime;
        if (CurrentTime >= MaxTime)
        {
            CurrentTime = 0f;
            Instantiate(BalloonsHard[Random.Range(0, BalloonsHard.Length)], new Vector3(Random.Range(MinX, MaxX), this.transform.position.y, 0), Quaternion.identity);

        }


    }
}
