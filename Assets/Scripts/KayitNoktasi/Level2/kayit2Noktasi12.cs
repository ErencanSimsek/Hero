using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayit2Noktasi12 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            kayit2Noktasi20.level2KayitNoktasi = 12;
        }
    }
}