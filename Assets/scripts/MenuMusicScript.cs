using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuMusicScript : MonoBehaviour
{
    AudioSource soundSource;

    public Slider sl;

    public float slvalue;

    private void Awake()
    {
        soundSource = GetComponent<AudioSource>();
        if (PlayerPrefs.HasKey("SoundVol"))
        {
            
            sl.value = PlayerPrefs.GetFloat("SoundVol");
            soundSource.volume = sl.value;
        }
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            soundSource.Play();
        }

    }

    private void Update()
    {
        soundSource.volume = sl.value;
        slvalue = sl.value;
        
    }
}
