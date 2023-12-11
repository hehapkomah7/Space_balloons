using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawnerNormal : MonoBehaviour
{
    public float MinX, MaxX;
    public GameObject[] BalloonsNormal;

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
            Instantiate(BalloonsNormal[Random.Range(0, BalloonsNormal.Length)], new Vector3(Random.Range(MinX, MaxX), this.transform.position.y, 0), Quaternion.identity);

        }


    }
}
