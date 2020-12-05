using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSystemScript : MonoBehaviour
{
    AudioSource SoundSource;
    public AudioClip enemyDead;
    public AudioClip TakeLive;
    public AudioClip TakeGems;
    public AudioClip PlayerDead;
    public AudioClip ShotSound;

    


    private void Start()
    {
        SoundSource = GetComponent<AudioSource>();
        if (PlayerPrefs.HasKey("SoundVol"))
        {
            SoundSource.volume = PlayerPrefs.GetFloat("SoundVol");
        }
    }

    public void EnemyDeadSound()
    {
        SoundSource.PlayOneShot(enemyDead);
    }
    
    public void TakeLiveSound()
    {
        SoundSource.PlayOneShot(TakeLive);
    }

    public void TakeGemsSound()
    {
        SoundSource.PlayOneShot(TakeGems);
    }
    public void PlayerDeadSound()
    {
        SoundSource.PlayOneShot(PlayerDead);
    }
    public void Shot()
    {
        SoundSource.PlayOneShot(ShotSound);
    }
    
}
