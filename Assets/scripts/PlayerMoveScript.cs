using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    public Joystick joystickSheli;
    Rigidbody rg;
    float mehirutTzuza = 0.09f;
    float mehirutSivuv = 0.8f;

    
    
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    
    private void FixedUpdate()
    {
        
        
        Vector3 tzuza = new Vector3(0, 0, joystickSheli.Vertical * mehirutTzuza);
        Vector3 sivuv = new Vector3(0, joystickSheli.Horizontal * mehirutSivuv, 0);
        transform.Translate(tzuza);
        transform.Rotate(sivuv);
    }



}
