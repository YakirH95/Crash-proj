using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelLevelTwoScript : MonoBehaviour
{
    public Text txt;
    float timeStart = 15;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("InfoLevel2"))
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
        yield return new WaitForSeconds(15.0f);
        PlayerPrefs.SetString("InfoLevel2", "OK");
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

        timeStart -= Time.deltaTime;
        txt.text = "Find all diamonds by looking at the map. " + 
            "\n" + "Take them by throwing nuts or collect it yourself." + 
            "\n" + "After collecting 4 hazelnuts, you will move on to the next section." + 
            "\n" + "be ready, the remaining time" + " : " + Convert.ToInt32(timeStart).ToString();
    }
    


}
