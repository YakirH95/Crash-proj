using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kiwiEngine : MonoBehaviour
{
    Animator anm;

    //movement
    bool canMove;
    float speed;
    Vector3 movement;

    public int life;

    //
    bool CanTakeLive = true;

    public AudioSystemScript SoundSend;

    // Start is called before the first frame update
    void Start()
    {
        anm = GetComponent<Animator>();

        canMove = true;
        speed = 0.3f * Time.deltaTime;
        movement = new Vector3(speed, 0, 0);

        life = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            handleMovement();
        }

        if (life == 0 && CanTakeLive == true)
        {
            
            anm.SetBool("isDead", true);
            canMove = false;
            //
            CanTakeLive = false;
            StartCoroutine("Destroythis");
        }
    }

    //
    IEnumerator Destroythis()
    {
        SoundSend.EnemyDeadSound();
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {                                               //
        if (collision.gameObject.tag == "ammo" && CanTakeLive == true)
        {
            life--;
            anm.SetBool("isDamaged", true);

        }
    }

    void handleMovement()
    {
        transform.position = new Vector3(transform.position.x + movement.x, transform.position.y, transform.position.z);

        if (transform.position.x >= 156)
        {
            movement = new Vector3(-speed, 0, 0);
            transform.localRotation = Quaternion.Euler(0, -90, 0);
        }

        else if (transform.position.x <= 149)
        {
            movement = new Vector3(speed, 0, 0);
            transform.localRotation = Quaternion.Euler(0, -270, 0);
        }
    }
}
