using UnityEngine;

public class LevelWiFi : MonoBehaviour
{
    bool wifibagla;
    [SerializeField] GameObject Canvas1, Canvas2, WiFiCanvas;
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
                Canvas1.SetActive(false);
                Canvas2.SetActive(false);
                WiFiCanvas.SetActive(true);
                Time.timeScale = 0;
                wifibagla = true;
            }
        }
        else if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork ||
            Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
        {
            if (wifibagla == true)
            {
                Canvas1.SetActive(true);
                Canvas2.SetActive(true);
                WiFiCanvas.SetActive(false);
                Time.timeScale = 1;
                wifibagla = false;
            }
        }
    }
}
