using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookY : MonoBehaviour
{
    float xRotation = 0;
    public float mouseSensitivity = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        xRotation -= mouseY;
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
    }
}
