using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownTrue : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<UpDown>().enabled = true;
        }
    }
}
