using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MoveJumpScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool is_Touched = false;
    float JumpPower = 13500f;
    float jumpControl = 1.0f;
    public GameObject player;
    Rigidbody rb;

    void Awake()
    {
        rb = player.GetComponent<Rigidbody>();
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
        jumpControl += Time.deltaTime;
        if (is_Touched == true)
        {
            if (jumpControl > 0.9f)
            {
                rb.AddForce(transform.up * JumpPower * Time.deltaTime);
                jumpControl = 0;
            }
        }

        else
        {

        }

    }

}
