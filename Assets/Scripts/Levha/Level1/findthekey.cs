using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findthekey : MonoBehaviour
{
    void Update()
    {
        if (Key.key == 2)
        {
            gameObject.SetActive(false);
        }
    }
}
