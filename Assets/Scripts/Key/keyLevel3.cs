using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keyLevel3 : MonoBehaviour
{
    public static bool level_3 = false;
    public static int home = 0;
    [SerializeField]
    GameObject KeyButton;

    void Update()
    {
        if (Key.key == 2)
        {
            KeyButton.SetActive(true);
        }
        if (home == 2)
        {
            level_3 = true;
            SceneManager.LoadScene("Level");
            KeyButton.SetActive(false);
        }
    }
}
