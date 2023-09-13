using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayit4Noktasi17 : MonoBehaviour
{
    public static int level2KayitNoktasi;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            level2KayitNoktasi = 17;
        }
    }
}
