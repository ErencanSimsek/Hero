using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keyLevel1 : MonoBehaviour
{
    public static int home = 0;
    public static bool level_1 = false;
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
            level_1 = true;
            SceneManager.LoadScene("Level");
            KeyButton.SetActive(false);
        }
    }
}
