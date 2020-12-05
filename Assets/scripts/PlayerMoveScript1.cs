using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerMoveScript1 : MonoBehaviour
{
    public Joystick joystickSheli;
    float mehirutSivuv = 0.8f;
    float PosY = 0;
    float PosX = 0;
    


    private void FixedUpdate()
    {
       
            PosY += joystickSheli.Horizontal * mehirutSivuv;
            PosX += -joystickSheli.Vertical;
            PosX = Mathf.Clamp(PosX, -22, 18);
            transform.localRotation = Quaternion.Euler(PosX, PosY, 0);

        
        

        
    }
}
