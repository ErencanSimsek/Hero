using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class igne : MonoBehaviour
{
    GameObject Player;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Hero.heroCan = 0;
        }
    }
}
