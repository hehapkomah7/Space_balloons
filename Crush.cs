using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crush : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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
