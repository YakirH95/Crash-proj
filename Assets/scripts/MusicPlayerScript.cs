using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;


public class MusicPlayerScript : MonoBehaviour
{
    AudioSource soundSource;
    
    


    private void Awake()
    {
        soundSource = GetComponent<AudioSource>();
        if(PlayerPrefs.HasKey("SoundVol"))
        {
            soundSource.volume = PlayerPrefs.GetFloat("SoundVol");
        }
    }

    private void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex == 3)
        {
            soundSource.Play();
        }
        
    }

    
}
