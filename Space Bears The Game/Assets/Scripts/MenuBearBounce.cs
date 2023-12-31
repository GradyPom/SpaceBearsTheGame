using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBearBounce : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public Rigidbody rb;

    public bool move = false;
    public bool moved = false;
    public float cd = 1;

    public AudioSource camAudio;
    public AudioSource bearAudio;
    public bool clicked = false;

    // Start is called before the first frame update
    void Start()
    {
        Physics.bounceThreshold = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!bearAudio.isPlaying && !camAudio.isPlaying)
        {
            SceneManager.LoadScene("CutScene");
        }

        rb.velocity = rb.velocity.normalized * speed;

        if (move && !moved)
        {
            moved = true;

            rb.AddForce(new Vector3(1, 1, 1).normalized * speed, ForceMode.Impulse);
            rb.AddTorque(0, 0, Random.Range(-rotationSpeed, rotationSpeed));
        }
        else
        {
            if(!moved)
            {
                cd -= Time.deltaTime;
            }
        }

        if (cd <= 0)
        {
            move = true;
        }
    }

    private void OnMouseDown()
    {
        if (!clicked)
        {
            clicked = true;
            bearAudio.Play();
            camAudio.Stop();
            rb.velocity = new Vector3(0,0,0);
        }


    }
}
