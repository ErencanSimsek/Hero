using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayit6Noktasi1 : MonoBehaviour
{
    public static int level6kayitNoktasi;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            level6kayitNoktasi = 1;
        }
    }
}
