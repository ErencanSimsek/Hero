using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayit2Noktasi8 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            kayit2Noktasi20.level2KayitNoktasi = 8;
        }
    }
}
