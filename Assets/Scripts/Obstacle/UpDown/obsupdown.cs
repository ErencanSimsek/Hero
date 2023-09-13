using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsupdown : MonoBehaviour
{
    Vector3 posA, posB, nexPos;
    float speed = 1;
    [SerializeField]
    Transform transformA, transformB;
    void Start()
    {
        posA = transformA.localPosition;
        posB = transformB.localPosition;
        nexPos = posB;
    }

    void Update()
    {
        Move();
    }

   

    void Move()
    {
        transformA.localPosition = Vector3.MoveTowards(transformA.localPosition, nexPos, speed * Time.deltaTime);
        if (Vector3.Distance(transformA.localPosition, nexPos) <= 0.1)
        {
            ChangeDestination();
        }
    }

    void ChangeDestination()
    {
        nexPos = nexPos != posA ? posA : posB;
        if (speed == 1)
        {
            speed = 3;
        }
        else if (speed == 3)
        {
            speed = 1;
        }
    }
}
