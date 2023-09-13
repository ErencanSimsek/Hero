using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownFalse : MonoBehaviour
{
    private void Update()
    {
        if (Key.key == 1)
        {
            gameObject.SetActive(false);
        }
    }
}
