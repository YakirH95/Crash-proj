using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptManagerInThisLevel1 : MonoBehaviour
{
    public Text Livetxt;
    int Live = 3;

    public GameObject myplayer;
    Vector3 startPos;

    public AudioSystemScript SoundSource;

    public Text Gemstxt;
    int GemsCount = 0;

    public Text TimeTxt;
    public float timeMinus = 15f;
    int timeToText;


    private void Awake()
    {
        startPos = myplayer.transform.position;
    }
    private void Start()
    {
        //timeToText = Convert.ToInt32(timeMinus);
        //TimeTxt.text = timeToText.ToString();
        Gemstxt.text = GemsCount.ToString();
        Livetxt.text = Live.ToString();
    }

    private void FixedUpdate()
    {
        if(GameObject.Find("Panel") == null)
        {
            timeMinus -= Time.deltaTime;
            timeToText = Convert.ToInt32(timeMinus);
            TimeTxt.text = timeToText.ToString();
        }
        

        if(timeMinus < 0)
        {
            timeMinus = 15f;
            LiveMinus();
        }
        if (Live < 1)
        {
            
            SceneManager.LoadScene(0);
        }
        if (GemsCount == 4)
        {
            SceneManager.LoadScene(2);
        }

    }

    

    public void LiveTake()
    {
        
        Live+=1;
        Livetxt.text = Live.ToString();
        SoundSource.TakeLiveSound();
    }
    public void LiveMinus()
    {
       
            Live -=1;
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
            timeMinus += 5;
        }
       
    }





}
