using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelButton : MonoBehaviour
{
    public Button Level2, Level3, Level4, Level5, Level6;
    public Image kilitli2, kilitli2acik, kilitli3, kilitli3acik, kilitli4, kilitli4acik, kilitli5, kilitli5acik, kilitli6, kilitli6acik;
    AudioSource source;
    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (keyLevel1.level_1 == true)
        {
            Level2.interactable = true;
            kilitli2.enabled = false;
            kilitli2acik.enabled = true;
            PlayerPrefs.SetString("level 2 active", "level 2 active");
        }
        if (keyLevel2.level_2 == true)
        {
            Level3.interactable = true;
            kilitli3.enabled = false;
            kilitli3acik.enabled = true;
            PlayerPrefs.SetString("level 3 active", "level 3 active");
        }
        if (keyLevel3.level_3 == true)
        {
            Level4.interactable = true;
            kilitli4.enabled = false;
            kilitli4acik.enabled = true;
            PlayerPrefs.SetString("level 4 active", "level 4 active");
        }
        if (keyLevel4.level_4 == true)
        {
            Level5.interactable = true;
            kilitli5.enabled = false;
            kilitli5acik.enabled = true;
            PlayerPrefs.SetString("level 5 active", "level 5 active");
        }
        if (keyLevel5.level_5 == true)
        {
            Level6.interactable = true;
            kilitli6.enabled = false;
            kilitli6acik.enabled = true;
            PlayerPrefs.SetString("level 6 active", "level 6 active");
        }
        if(PlayerPrefs.HasKey("level 2 active"))
        {
            Level2.interactable = true;
            kilitli2.enabled = false;
            kilitli2acik.enabled = true;
        }
        if (PlayerPrefs.HasKey("level 3 active"))
        {
            Level3.interactable = true;
            kilitli3.enabled = false;
            kilitli3acik.enabled = true;
        }
        if (PlayerPrefs.HasKey("level 4 active"))
        {
            Level4.interactable = true;
            kilitli4.enabled = false;
            kilitli4acik.enabled = true;
        }
        if (PlayerPrefs.HasKey("level 5 active"))
        {
            Level5.interactable = true;
            kilitli5.enabled = false;
            kilitli5acik.enabled = true;
        }
        if (PlayerPrefs.HasKey("level 6 active"))
        {
            Level6.interactable = true;
            kilitli6.enabled = false;
            kilitli6acik.enabled = true;
        }
    }
    public void back()
    {
        source.Play();
        SceneManager.LoadScene("SampleScene");
    }
}
