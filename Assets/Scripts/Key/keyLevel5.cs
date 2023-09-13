using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keyLevel5 : MonoBehaviour
{
    public static bool level_5 = false;
    [SerializeField]
    GameObject KeyButton;

    void Update()
    {
        if (Key.key == 1)
        {
            KeyButton.SetActive(true);
        }
        if (keyLevel3.home == 1)
        {
            level_5 = true;
            SceneManager.LoadScene("Level");
            KeyButton.SetActive(false);
        }
    }
}
