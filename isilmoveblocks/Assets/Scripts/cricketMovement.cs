using UnityEngine;

public class cricketMovement : MonoBehaviour
{
    public float movementSpeed = 8f;
    public int collectCoinCounter = 0;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            //transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            //transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
            transform.rotation = Quaternion.Euler(0, -90, 0);
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            //transform.position += transform.TransformDirection(Vector3.right) * Time.deltaTime * movementSpeed;
            transform.rotation = Quaternion.Euler(0, 90, 0);
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }
    }


}