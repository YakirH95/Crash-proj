using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stumpyEngine : MonoBehaviour
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
        speed = 0.5f * Time.deltaTime;
        movement = new Vector3(0, 0, speed);

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
    {
        if (collision.gameObject.tag == "ammo" && CanTakeLive == true)
        {
            life--;
            anm.SetBool("isDamaged", true);

        }
    }

    void handleMovement()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + movement.z);

        if (transform.position.z >= 144)
        {
            movement = new Vector3(0, 0, -speed);
            transform.localRotation = Quaternion.Euler(0, -90, 0);
        }

        else if (transform.position.z <= 141)
        {
            movement = new Vector3(0, 0, speed);
            transform.localRotation = Quaternion.Euler(0, 90, 0);
        }
    }
}
