using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level5 : MonoBehaviour
{
    public void level_5()
    {
        keyLevel3.home = 0;
        Key.key = 0;
        SceneManager.LoadScene("level5");
        music.Instance.gameObject.SetActive(false);
    }
}
