using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonControllerNormal : MonoBehaviour
{
    public Rigidbody2D Rb;
    public float Speed = 2.5f;

    public Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5f);


    }

    // Update is called once per frame
    void Update()
    {
        Rb.velocity = new Vector2(0, Speed);

    }
}
