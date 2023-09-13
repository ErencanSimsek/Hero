using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayit1Noktasi1 : MonoBehaviour
{
    public static int level1KayitNoktasi;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            level1KayitNoktasi = 1;
        }
    }
}
