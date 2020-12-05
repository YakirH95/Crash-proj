using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContinueScript : MonoBehaviour
{
    int level;

    void Start()
    {
        if(PlayerPrefs.HasKey("Load"))
        {
            level = PlayerPrefs.GetInt("Load");
        }
        else
        {
            this.GetComponent<Button>().interactable = false;
        }
        
    }


    public void LoadLevel()
    {
        SceneManager.LoadScene(level);
    }
    
}
