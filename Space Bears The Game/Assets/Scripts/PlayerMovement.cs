using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12;
    Vector3 velocity;
    public float gravity = -9.81f;
    //public bool isOnGround;
    //public float jumpForce = 20;
    //public Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        //playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(isOnGround && Input.GetKeyDown(KeyCode.Space))
        //{
            //playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //isOnGround = false;
        //}

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    //private void OnCollisonEnter(Collision collsion)
    //{
        //if(collsion.gameObject.CompareTag("Ground"))
        //{
            //isOnGround = true;
        //}
    //}
}
