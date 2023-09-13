using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraAlani : MonoBehaviour
{
    private Camera maincamera;

    void Start()
    {
        maincamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        transform.position = new Vector3(maincamera.transform.position.x, maincamera.transform.position.y, 0);
        Vector3 bootomLeft = maincamera.ViewportToWorldPoint(Vector3.zero) * 100;
        Vector3 topRight = maincamera.ViewportToWorldPoint(new Vector3(maincamera.rect.width, maincamera.rect.height)) * 100;
        Vector3 screenSize = topRight - bootomLeft;
        float screenRatio = screenSize.x / screenSize.y;
        float desiredRatio = transform.localScale.x / transform.localScale.y;

        if(screenRatio > desiredRatio)
        {
            float height = screenSize.y;
            transform.localScale = new Vector3(height * desiredRatio, height);
        }
        else
        {
            float widht = screenSize.y;
            transform.localScale = new Vector3(widht, widht / desiredRatio);
        }
    }
}
