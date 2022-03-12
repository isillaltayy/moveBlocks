using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public float speed = 8f;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += Vector3.right * speed * Time.fixedDeltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position -= Vector3.right * speed * Time.fixedDeltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.position += Vector3.forward * speed * Time.fixedDeltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.transform.position -= Vector3.forward * speed * Time.fixedDeltaTime;
        }

    }
}

