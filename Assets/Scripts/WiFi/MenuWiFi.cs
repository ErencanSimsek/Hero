using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuWiFi : MonoBehaviour
{
    [SerializeField]
    GameObject Canvas, WiFiCanvas;
    bool wifibagla;
    private void Start()
    {
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
                Time.timeScale = 0;
                Canvas.SetActive(false);
                WiFiCanvas.SetActive(true);
                wifibagla = true;
            }
        }
        else if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork ||
            Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
        {
            if (wifibagla == true)
            {
                Time.timeScale = 1;
                Canvas.SetActive(true);
                WiFiCanvas.SetActive(false);
                wifibagla = false;
            }
        }
    }
}
