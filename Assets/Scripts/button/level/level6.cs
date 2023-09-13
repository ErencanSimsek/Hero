using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level6 : MonoBehaviour
{
    public void level_6()
    {
        keyLevel3.home = 0;
        Key.key = 0;
        SceneManager.LoadScene("level6");
        music.Instance.gameObject.SetActive(false);
    }
}
