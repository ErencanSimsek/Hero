using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ates6 : MonoBehaviour
{
    [SerializeField]
    GameObject mermi;
    int zaman = 0;
    public static bool a;

    private void Start()
    {
        a = true;
    }
    private void Update()
    {
        if(Key.key == 1 && a == true)
        {
            if (zaman == 0)
            {
                Instantiate(mermi, transform.position, Quaternion.identity);
                zaman = 500;
            }
            zaman--;
        }
    }
}
