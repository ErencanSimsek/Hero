using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayit5Noktasi7 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            kayit5Noktasi1.level2KayitNoktasi = 7;
        }
    }
}
