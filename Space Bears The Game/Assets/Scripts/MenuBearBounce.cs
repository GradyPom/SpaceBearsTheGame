using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBearBounce : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Physics.bounceThreshold = 0;

        rb.AddForce(new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1)).normalized * speed, ForceMode.Impulse);
        rb.AddTorque(0, 0, Random.Range(-rotationSpeed,rotationSpeed));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = rb.velocity.normalized * speed;
    }
}
