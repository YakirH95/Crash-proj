using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptManagerInThisLevel : MonoBehaviour
{
    public Text Livetxt;
    int Live = 3;

    public GameObject myplayer;
    public Vector3 startPos;

    public AudioSystemScript SoundSource;

    public Text Gemstxt;
    int GemsCount = 0;

    private void Awake()
    {
        startPos = myplayer.transform.position;
    }
    private void Start()
    {
        Gemstxt.text = GemsCount.ToString();
        Livetxt.text = Live.ToString();
    }

    public void LiveTake()
    {
        
        Live+=1;
        Livetxt.text = Live.ToString();
        SoundSource.TakeLiveSound();
    }
    public void LiveMinus()
    {
        
       
        Live -= 1;
        Livetxt.text = Live.ToString();
        myplayer.transform.position = startPos;
        SoundSource.PlayerDeadSound();
    }


    public void GemsCheck()
    {
        if(GemsCount < 4)
        {
            GemsCount += 1;
            Gemstxt.text = GemsCount.ToString();
            SoundSource.TakeGemsSound();
        }
        
    }
    private void Update()
    {
        if (GemsCount == 4)
        {
            PlayerPrefs.SetInt("Load", SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene(0);
        }
        if (Live < 1)
        {
            PlayerPrefs.SetInt("Load", SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene(0);
        }
    }





}
