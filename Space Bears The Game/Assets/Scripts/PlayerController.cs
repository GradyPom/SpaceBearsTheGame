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

    private GameManager gm;

    public float dist;
    public GameObject[] bears;
    public Transform[] bearPositions;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        gm = FindObjectOfType<GameManager>();
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

        if(gameObject.transform.position.y <= 2.1)
        {
            gm.health = 0;
        }

        bears = GameObject.FindGameObjectsWithTag("Bear");
        bearPositions = new Transform[bears.Length];
        for (int i = 0; i < bears.Length; i++)
        {
            bearPositions[i] = bears[i].transform;
        }
        GetClosestBear(bearPositions);
    }

    void GetClosestBear(Transform[] bears)
    {
        Transform bestTarget = null;
        float closestDistanceSqr = Mathf.Infinity;
        Vector3 currentPosition = transform.position;
        foreach (Transform potentialTarget in bears)
        {
            Vector3 directionToTarget = potentialTarget.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            if (dSqrToTarget < closestDistanceSqr)
            {
                closestDistanceSqr = dSqrToTarget;
                bestTarget = potentialTarget;
            }
        }
        dist = Mathf.Round(Mathf.Sqrt(closestDistanceSqr));
    }
}
