using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayit6Noktasi7 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            kayit6Noktasi1.level6kayitNoktasi = 7;
        }
    }
}
