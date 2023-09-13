using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level4 : MonoBehaviour
{
    public void level_4()
    {
        keyLevel3.home = 0;
        Key.key = 0;
        SceneManager.LoadScene("level4");
        music.Instance.gameObject.SetActive(false);  
    }
}
