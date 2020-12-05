using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3Music : MonoBehaviour
{
    AudioSource soundSource;




    private void Awake()
    {
        soundSource = GetComponent<AudioSource>();
        if (PlayerPrefs.HasKey("SoundVol"))
        {
            soundSource.volume = PlayerPrefs.GetFloat("SoundVol");
        }
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            soundSource.Play();
        }

    }
}
