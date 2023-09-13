using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownFalse4 : MonoBehaviour
{
    private void Update()
    {
        if (buton.active == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
        else if (buton.active == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
