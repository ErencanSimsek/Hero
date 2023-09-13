using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findthekey2 : MonoBehaviour
{
    void Update()
    {
        if (Key.key == 1)
        {
            gameObject.SetActive(false);
        }
    }
}
