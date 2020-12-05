using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeScript : MonoBehaviour
{
    public GameObject gemsMy;


    private void Update()
    {
        if(gemsMy == null)
        {
            Destroy(gameObject);
        }
    }
}
