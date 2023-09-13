using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayit3Noktasi12 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            kayit3Noktasi20.level2KayitNoktasi = 12;
        }
    }
}
