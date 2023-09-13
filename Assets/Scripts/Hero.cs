using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField]
    AudioClip jumpp;
    public static int heroCan = 1;
    float hareketHiz = 3.5f, ziplamaHiz = 70f;
    Animator animator;
    Rigidbody2D rb;
    public static bool move = false;
    bool Temas = false, Jump = false;
    AudioSource source;
    
    void Start()
    {
        source = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void leftWalk()
    {
        animator.SetBool("walk", true);
        source.Play();
        move = true;
        transform.rotation = Quaternion.Euler(0, 180, 0);
        if (hareketHiz == 3.5f)
        {
            hareketHiz *= -1;
        }
    }
    public void rightWalk()
    {
        animator.SetBool("walk", true);
        source.Play();
        move = true;
        transform.rotation = Quaternion.Euler(0, 0, 0);
        if (hareketHiz == -3.5f)
        {
            hareketHiz *= -1;
        }
    }
    public void stop()
    {
        source.Stop();
        animator.SetBool("walk", false);
        move = false;
    }
    public void jump()
    {
        if (Temas == true)
        {
            animator.SetTrigger("jump");
            source.PlayOneShot(jumpp);
            Jump = true;
        }
    }
    void FixedUpdate()
    {
        if (move == true)
        {
            transform.position += new Vector3(hareketHiz * Time.deltaTime,0);
        }
        if (Jump == true)
        {
            transform.position += new Vector3(0, ziplamaHiz * Time.deltaTime);
            Jump = false;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "cimen" || collision.gameObject.tag == "car" || collision.gameObject.tag == "updown" || collision.gameObject.tag == "Home2")
        {
            Temas = true;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "cimen" || collision.gameObject.tag == "car" || collision.gameObject.tag == "updown" || collision.gameObject.tag == "Home2")
        {
            Temas = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "cimen" || collision.gameObject.tag == "car" || collision.gameObject.tag == "updown" || collision.gameObject.tag == "Home2")
        {
            Temas = false;
        }
    }
}
