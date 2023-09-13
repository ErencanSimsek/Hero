using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiFiControl : MonoBehaviour
{
    bool wifibagla;
    private void Start()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            wifibagla = false;
        }
        else if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork ||
            Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
        {
            wifibagla = true;
        }
        wifi();
    }
    private void Update()
    {
        wifi();
    }
    void wifi()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            if (wifibagla == false)
            {

                wifibagla = true;
            }
        }
        else if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork ||
            Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
        {
            if (wifibagla == true)
            {
                wifibagla = false;
            }
        }
    }
}