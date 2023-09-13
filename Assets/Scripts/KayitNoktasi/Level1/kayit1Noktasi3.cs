using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayit1Noktasi3 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            kayit1Noktasi1.level1KayitNoktasi = 3;
        }
    }
}
