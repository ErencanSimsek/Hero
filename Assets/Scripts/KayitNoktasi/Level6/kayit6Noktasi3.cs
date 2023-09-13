using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayit6Noktasi3 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            kayit6Noktasi1.level6kayitNoktasi = 3;
        }
    }
}
