using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownTrue3 : MonoBehaviour
{
    private void Update()
    {
        if (keyLevel3.home == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
            gameObject.GetComponent<PlatformEffector2D>().enabled = true;
        }
    }
}
