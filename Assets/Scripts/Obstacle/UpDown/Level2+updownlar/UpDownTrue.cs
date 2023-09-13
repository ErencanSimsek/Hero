using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownTrue : MonoBehaviour
{
    private void Update()
    {
        if (Key.key == 1)
        {
            gameObject.GetComponent<UpDown>().enabled = true;
        }
    }
}
