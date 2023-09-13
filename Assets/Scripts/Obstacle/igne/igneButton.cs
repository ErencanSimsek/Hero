using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class igneButton : MonoBehaviour
{
    void Update()
    {
        if (button.active == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            gameObject.GetComponent<PolygonCollider2D>().enabled = true;
        }
    }
}
