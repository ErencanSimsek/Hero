using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buton : MonoBehaviour
{
    public static int active = 0;
    [SerializeField]
    GameObject kutu, Player;
    Vector3 vector3Button;
    private void Start()
    {
        vector3Button = transform.localPosition;
    }
    private void Update()
    {
        if (Vector3.Distance(transform.localPosition, kutu.transform.localPosition) <= 1f ||
            Vector3.Distance(transform.localPosition, Player.transform.localPosition) <= 1.3f)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            active = 1;
        }
        if (Vector3.Distance(vector3Button, kutu.transform.localPosition) >= 1f &&
            Vector3.Distance(vector3Button, Player.transform.localPosition) >= 1.3f)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
            active = 0;
        }
    }
}
