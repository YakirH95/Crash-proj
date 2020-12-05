using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gemMovement : MonoBehaviour
{
    float speed;
    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.2f * Time.deltaTime;
        movement = new Vector3(0, speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 100 * Time.deltaTime);

        transform.position = new Vector3(transform.position.x, transform.position.y + movement.y, transform.position.z);

        if (transform.position.y >= 152f)
        {
            movement = new Vector3(0, -speed, 0);        
        }

        else if (transform.position.y <= 151.5f)
        {
            movement = new Vector3(0, speed, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
