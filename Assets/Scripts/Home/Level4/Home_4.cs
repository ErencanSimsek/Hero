using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Home_4 : MonoBehaviour
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
        if (Vector3.Distance(transform.localPosition, Player.transform.localPosition) <= 5 && gameObject.tag == "Home1")
        {
            Hero.move = false;
            openingdoor.GetComponent<AudioSource>().Play();
            keyLevel3.home += 1;
            homeText.text = keyLevel3.home.ToString();
            gameObject.tag = "Untagged";
        }
    }
}
