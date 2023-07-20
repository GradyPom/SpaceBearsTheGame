using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMove : MonoBehaviour
{
    public float speed = 30;
    public float laserStrength;
    public float laserCooldown;
    public AudioClip laserSound;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        laserStrength = 10;
        laserCooldown = 1;
        audioSource.PlayOneShot(laserSound, 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
