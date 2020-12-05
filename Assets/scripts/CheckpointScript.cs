using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    public ScriptManagerInThisLevel managerGame;
    public AudioSystemScript soundmanager;




    void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            soundmanager.TakeLiveSound();
            managerGame.startPos = transform.position;
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        transform.Rotate(0, 30 * Time.deltaTime, 0);
    }



}
