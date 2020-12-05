using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShotScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool is_Touched = false;
    public GameObject Finduk;
    float FindukShotControl = 1.0f;
    public GameObject pl;

    GameObject cam;


    void Awake()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
    }



    public void OnPointerDown(PointerEventData eventData)
    {

        is_Touched = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {

        is_Touched = false;

    }



    void FixedUpdate()
    {
        FindukShotControl += Time.deltaTime;
        if (is_Touched == true)
        {
            if (FindukShotControl > 0.9f)
            {

               GameObject PreFinduk = Instantiate(Finduk,pl.transform.position + pl.transform.forward, Finduk.transform.rotation);
                PreFinduk.transform.forward = cam.transform.forward;
                FindukShotControl = 0;
            }
        }

        else
        {

        }

    }
}
