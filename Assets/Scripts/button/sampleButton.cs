using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sampleButton : MonoBehaviour
{
    AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void play()
    {
        source.Play();
        SceneManager.LoadScene("Level");
    }
    public void quit()
    {
        Application.Quit();
    }
    
}
