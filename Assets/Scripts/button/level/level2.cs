using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level2 : MonoBehaviour
{
    public void level_2()
    {
        keyLevel1.home = 0;
        Key.key = 0;
        SceneManager.LoadScene("level2");
        music.Instance.gameObject.SetActive(false);
    }
}
