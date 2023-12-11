using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public Rigidbody2D Rb;
    public float Speed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 3f);

    }

    // Update is called once per frame
    void Update()
    {
        Rb.velocity = new Vector2(0, Speed);

    }

    private void OnTriggerEnter2D(Collider2D cother)
    {
        if (cother.gameObject.CompareTag("Balloon_normal"))
        {
            Destroy(cother.gameObject);
        }

        if (cother.gameObject.CompareTag("Balloon_good"))
        {
            Destroy(cother.gameObject);
        }

        if (cother.gameObject.CompareTag("Balloon_bad"))
        {
            Destroy(cother.gameObject);
        }

        if (cother.gameObject.CompareTag("Balloon_question"))
        {
            Destroy(cother.gameObject);
        }


        if (cother.gameObject.CompareTag("Balloon_end"))
        {
            Destroy(cother.gameObject);
        }

    }

}
