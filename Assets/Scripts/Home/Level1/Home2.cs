using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Home2 : MonoBehaviour
{
    public TextMeshProUGUI homeText;
    GameObject Player, openingdoor;
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        openingdoor = GameObject.FindGameObjectWithTag("opening-door");
    }

    public void key()
    {
        if (Vector3.Distance(transform.localPosition, Player.transform.localPosition) <= 8 && gameObject.tag == "Home2")
        {
            Hero.move = false;
            openingdoor.GetComponent<AudioSource>().Play();
            keyLevel1.home += 1;
            homeText.text = keyLevel1.home.ToString();
            gameObject.tag = "Untagged";
        }
    }
}
