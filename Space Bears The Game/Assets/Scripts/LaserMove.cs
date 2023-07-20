using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMove : MonoBehaviour
{
    public float speed = 30;
    public float laserStrength;
    public float laserCooldown;

    // Start is called before the first frame update
    void Start()
    {
        laserStrength = 10;
        laserCooldown = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
