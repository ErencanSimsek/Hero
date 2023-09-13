using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homethekey2 : MonoBehaviour
{
    [SerializeField]
    GameObject GoTheHome;
    void Update()
    {
        if (Key.key == 1)
        {
            GoTheHome.SetActive(true);
        }
    }
}
