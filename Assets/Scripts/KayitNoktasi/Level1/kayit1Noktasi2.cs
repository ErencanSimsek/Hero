using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayit1Noktasi2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            kayit1Noktasi1.level1KayitNoktasi = 2;
        }
    }
}
