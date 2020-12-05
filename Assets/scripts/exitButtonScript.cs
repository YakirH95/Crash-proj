using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class exitButtonScript : MonoBehaviour
{

    public void ExitToMenu()
    {
        int level = SceneManager.GetActiveScene().buildIndex;
        if(level >= 2)
        {
            PlayerPrefs.SetInt("Load", level);
        }
        SceneManager.LoadScene(0);

    }
    



}
