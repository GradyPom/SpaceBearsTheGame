using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float verticalInput;
    private float horizontalInput;
    public int speed = 10;
    public int turnSpeed = 15;
    public float mouseSensitivity = 100;
    public Transform playerBody;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
