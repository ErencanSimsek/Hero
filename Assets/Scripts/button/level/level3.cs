using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level3 : MonoBehaviour
{
    
    public void level_3()
    {
        keyLevel3.home = 0;
        Key.key = 0;
        SceneManager.LoadScene("level3");
        music.Instance.gameObject.SetActive(false);
    }
}
