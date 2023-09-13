using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gothehome : MonoBehaviour
{
    [SerializeField]
    GameObject  GoTheHome;
    void Update()
    {
        if (Key.key == 2)
        {
            GoTheHome.SetActive(true);
        }
    }
}
