using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BearMove : MonoBehaviour
{

    public Transform player;
    int speed = 12;
    int MinDist = 2;
    public CharacterController controller;
    Vector3 velocity;
    public float gravity = -9.81f;
    public GameObject bear;

    void Start()
    {
        player = GameObject.Find("Player Body").transform;
    }

    void Update()
    {
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        if (Vector3.Distance(transform.position, player.position) >= MinDist)
        {
            if (bear.GetComponent<CollisionDetecter>().runAnimationHolder == 0)
            {
                GetComponent<Animator>().SetBool("Run Forward", true);
                transform.position += transform.forward * speed * Time.deltaTime;
                transform.LookAt(player);
            }
            else
            {
                GetComponent<Animator>().SetBool("Run Forward", false);
            }
        }
        else
        {
            GetComponent<Animator>().SetBool("Run Forward", false);
        }
    }
}
