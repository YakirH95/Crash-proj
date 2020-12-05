using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindukScript : MonoBehaviour
{
    float Power = 6;
    GameObject cam;
    AudioSystemScript SoundManager;


    void Awake()
    {
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

    



    private void FixedUpdate()
    {
        transform.Translate(0, Power * Time.deltaTime / 2, Power * Time.deltaTime);
        //transform.position += transform.forward * Power * Time.deltaTime;
    }
}
