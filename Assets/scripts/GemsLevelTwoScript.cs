using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemsLevelTwoScript : MonoBehaviour
{
    // Start is called before the first frame update
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
        transform.Rotate(100 * Time.deltaTime, 100 * Time.deltaTime, 0);

        

        if (transform.position.y >= 151f)
        {
            movement = new Vector3(0, -speed, 0);
        }

        else if (transform.position.y <= 150.5f)
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
