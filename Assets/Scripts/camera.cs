using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    Vector2 velocity;
    GameObject Player;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    
    void Update()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, Player.transform.position.x, ref velocity.x, 0.01f);
        float posY = Mathf.SmoothDamp(transform.position.y, Player.transform.position.y + 1.6f, ref velocity.y, 0.5f);

        transform.position = new Vector3(posX, posY, transform.position.z);
    }
}
