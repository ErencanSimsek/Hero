using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level1 : MonoBehaviour
{
    public void level_1()
    {
        keyLevel1.home = 0;
        Key.key = 0;
        SceneManager.LoadScene("level1");
        music.Instance.gameObject.SetActive(false);
    }
}
