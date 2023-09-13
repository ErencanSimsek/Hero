using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public int platformCan = 23;
    
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            platformCan--;
            if (platformCan == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
