using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float movementForce;
    public float jumpForce;

    public Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame - once every 16.6666ms
    // 1000ms for each second
    // approximately updates 60 times per second = 60fps
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal")> 0)
        {
            // Move Right
            rigidBody.AddForce(Vector3.right * movementForce);
            Debug.Log("Moving Right");
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            // Move Left
            rigidBody.AddForce(Vector3.left * movementForce);
            Debug.Log("Moving Left");
        }
        if (Input.GetAxisRaw("Jump") > 0)
        {
            // Jump
            rigidBody.AddForce(Vector3.up * jumpForce);
        }
    }
}
