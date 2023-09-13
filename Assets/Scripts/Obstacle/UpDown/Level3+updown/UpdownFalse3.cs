using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdownFalse3 : MonoBehaviour
{
    private void Update()
    {
        if (keyLevel3.home == 1)
        {
            gameObject.SetActive(false);
        }
    }
}
