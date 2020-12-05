﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGameScript2: MonoBehaviour
{
    public ScriptManagerInThisLevel2 managerGame;

    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Enemies")
        {
            managerGame.LiveMinus();
        }
        
        if(collision.collider.gameObject.tag == "Gems")
        {
            Destroy(collision.collider.gameObject);
            managerGame.GemsCheck();
        }

        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Live")
        {
            managerGame.LiveTake();
        }
    }


}