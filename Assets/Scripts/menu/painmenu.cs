using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class painmenu : MonoBehaviour
{
    [SerializeField]
    GameObject Play, Pause, painMenu, dieMenu, left, right, up, Player, Music, dieMenu1;
    AudioSource source;
    public static int yanma = 0;
    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Hero.heroCan == 0 && yanma == 0)
        {
            Music.GetComponent<AudioSource>().enabled = false;
            Player.GetComponent<AudioSource>().enabled = false;
            dieMenu.SetActive(true);
            Time.timeScale = 0f;
            Pause.SetActive(true);
            Play.SetActive(false);
            left.SetActive(false);
            right.SetActive(false);
            up.SetActive(false);
        }
        else if (Hero.heroCan == 0 && yanma == 1)
        {
            Music.GetComponent<AudioSource>().enabled = false;
            Player.GetComponent<AudioSource>().enabled = false;
            dieMenu1.SetActive(true);
            Time.timeScale = 0f;
            Pause.SetActive(true);
            Play.SetActive(false);
            left.SetActive(false);
            right.SetActive(false);
            up.SetActive(false);
        }
    }
    public void play()
    {
        source.Play();
        Music.GetComponent<AudioSource>().enabled = false;
        painMenu.SetActive(true);
        Time.timeScale = 0f;
        Pause.SetActive(true);
        Play.SetActive(false);
        left.SetActive(false);
        right.SetActive(false);
        up.SetActive(false);
    }
    public void pause()
    {
        source.Stop();
        Music.GetComponent<AudioSource>().enabled = true;
        painMenu.SetActive(false);
        Time.timeScale = 1f;
        Play.SetActive(true);
        Pause.SetActive(false);
        left.SetActive(true);
        right.SetActive(true);
        up.SetActive(true);
    }
    public void devamet()
    {
        source.Stop();
        Music.GetComponent<AudioSource>().enabled = true;
        painMenu.SetActive(false);
        Time.timeScale = 1f;
        Play.SetActive(true);
        Pause.SetActive(false);
        left.SetActive(true);
        right.SetActive(true);
        up.SetActive(true);
    }
    public void tekraroyna()
    {
        source.Stop();
        Scene scene;
        scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Time.timeScale = 1f;
        keyLevel3.home = 0;
        Hero.heroCan = 1;
        Hero.move = false;
        Key.key = 0;
        yanma = 0;
    }
    public void quit()
    {
        Application.Quit();
    }
}
