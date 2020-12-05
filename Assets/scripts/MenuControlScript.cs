using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControlScript : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject settingsPanel;
    public MenuMusicScript volSave;

    public Text LevelCheck;
    int levelNo = 1;


    private void Start()
    {
        LevelCheck.text = levelNo.ToString();
        settingsPanel.SetActive(false);
        menuPanel.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    void Update()
    {
        LevelCheck.text = levelNo.ToString();
    }

    public void levelNumPlus()
    {
        if (levelNo < 3)
        {
            levelNo += 1;
        }
        

    }
    public void levelNumMinus()
    {
        if (levelNo > 1)
        {
            levelNo -= 1;
        }

    }


    public void LevelGo()
    {
        SceneManager.LoadScene(levelNo);
    }

    public void GoSettings()
    {
        settingsPanel.SetActive(true);
        menuPanel.SetActive(false);
    }

    public void GoBack()
    {
        PlayerPrefs.SetFloat("SoundVol", volSave.slvalue);
        settingsPanel.SetActive(false);
        menuPanel.SetActive(true);
    }

}
