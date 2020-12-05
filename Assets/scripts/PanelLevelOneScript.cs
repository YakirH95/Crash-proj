using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelLevelOneScript : MonoBehaviour
{
    public Text txt;
    float timeStart = 10;
    // Start is called before the first frame update
    void Start()
    {
     if(PlayerPrefs.HasKey("InfoLevel1"))
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
        yield return new WaitForSeconds(10.0f);
        PlayerPrefs.SetString("InfoLevel1", "OK");
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

        timeStart -= Time.deltaTime;
        txt.text = "You have to throw hazelnuts on all the diamonds around. " + "\n" + "When 4 hazelnuts touch 4 diamonds, you will pass the next section." + "\n" + "be ready, the remaining time" + " : " + Convert.ToInt32(timeStart).ToString();
    }
}
