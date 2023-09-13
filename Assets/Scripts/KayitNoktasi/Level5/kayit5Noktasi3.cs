using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayit5Noktasi3 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            kayit5Noktasi1.level2KayitNoktasi = 3;
        }
    }
}
