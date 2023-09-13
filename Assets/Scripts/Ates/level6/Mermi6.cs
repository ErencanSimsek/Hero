using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mermi6 : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 5f;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector3.left * speed;
        Destroy(gameObject, 8);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Hero.heroCan = 0;
            Destroy(gameObject);
            Ates6.a = false;
        }
    }
}
