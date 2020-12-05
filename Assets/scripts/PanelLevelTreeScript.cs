using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelLevelTreeScript : MonoBehaviour
{
    public Text txt;
    float timeStart = 12;
    
    void Start()
    {
        if (PlayerPrefs.HasKey("InfoLevel3"))
        {
            Destroy(gameObject);
        }
        else
        {

            StartCoroutine(DestroyMyInfo());
        }
    }

    IEnumerator DestroyMyInfo()
    {
        yield return new WaitForSeconds(12.0f);
        PlayerPrefs.SetString("InfoLevel3", "OK");
        Destroy(gameObject);
    }

   
    void Update()
    {

        timeStart -= Time.deltaTime;
        txt.text = "You are no longer alone," + "\n" + "your enemies and you have many difficulties to go through. " + "\n" + "now collect 4 diamonds but this time you can only collect them yourself" + "\n" + " you cannot use nuts to collect diamonds." + "\n" + "be ready, the remaining time" + " : " + Convert.ToInt32(timeStart).ToString();
    }

    

}
