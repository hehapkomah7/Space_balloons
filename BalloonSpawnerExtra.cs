using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawnerExtra : MonoBehaviour
{
    public float MinX, MaxX;
    public GameObject[] BalloonsExtra;

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
            Instantiate(BalloonsExtra[Random.Range(0, BalloonsExtra.Length)], new Vector3(Random.Range(MinX, MaxX), this.transform.position.y, 0), Quaternion.identity);

        }


    }
}
