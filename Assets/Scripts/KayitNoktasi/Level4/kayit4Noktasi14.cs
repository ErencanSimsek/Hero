using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayit4Noktasi14 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            kayit4Noktasi17.level2KayitNoktasi = 14;
        }
    }
}
