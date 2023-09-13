using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updownposA : MonoBehaviour
{
    GameObject Player;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Hero.heroCan = 0;
        }
    }
}
