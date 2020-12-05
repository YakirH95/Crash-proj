using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FindukScript2 : MonoBehaviour
{
    float Power = 6;
    GameObject cam;
    AudioSystemScript SoundManager;

    ScriptManagerInThisLevel2 managerGame;
    


    void Awake()
    {
        managerGame = GameObject.FindGameObjectWithTag("GameManagerMy").GetComponent<ScriptManagerInThisLevel2>();
        SoundManager = GameObject.FindGameObjectWithTag("Sound").GetComponent<AudioSystemScript>();
        cam = GameObject.FindGameObjectWithTag("MainCamera");
    }
    private void Start()
    {
        SoundManager.Shot();
        StartCoroutine("DestroyMy");
        //transform.forward = cam.transform.forward;
    }

    IEnumerator DestroyMy()
    {

        yield return new WaitForSeconds(1.3f);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Gems")
        {
            Destroy(collision.collider.gameObject);
            managerGame.GemsCheck();
        }
    }





    private void FixedUpdate()
    {
        transform.Translate(0, Power * Time.deltaTime / 2, Power * Time.deltaTime);
        //transform.position += transform.forward * Power * Time.deltaTime;
    }
}
