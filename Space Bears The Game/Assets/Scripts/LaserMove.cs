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
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        laserStrength = 10;
        laserCooldown = 1;
        audioSource.PlayOneShot(laserSound, 1);
        player = GameObject.Find("Player Body");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if(player.transform.position.x + 300 <= transform.position.x)
        {
            Destroy(gameObject);
        }
        else if (player.transform.position.z + 300 <= transform.position.z)
        {
            Destroy(gameObject);
        }
        else if (player.transform.position.x - 300 >= transform.position.x)
        {
            Destroy(gameObject);
        }
        else if (player.transform.position.z - 300 >= transform.position.z)
        {
            Destroy(gameObject);
        }
    }

    public void OnCollisonEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
