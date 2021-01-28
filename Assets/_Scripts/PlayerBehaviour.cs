using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float movementForce;
    public float jumpForce;
    public bool isGrounded;

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
        if (isGrounded)
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

            if (Input.GetAxisRaw("Vertical") > 0)
            {
                // Move Forward
                rigidBody.AddForce(Vector3.forward * movementForce);
                Debug.Log("Moving Right");
            }

            if (Input.GetAxisRaw("Vertical") < 0)
            {
                // Move Backwards
                rigidBody.AddForce(Vector3.back * movementForce);
                Debug.Log("Moving Left");
            }

            if (Input.GetAxisRaw("Jump") > 0)
            {
                // Jump
                rigidBody.AddForce(Vector3.up * jumpForce);
            }
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
