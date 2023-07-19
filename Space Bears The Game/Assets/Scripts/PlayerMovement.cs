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
    public GameManager gm;
    public GameObject upgradeScreen;
    public bool upgradeScreenOpen = false;
    public GameObject inGameUI;
    public GameObject laser;
    //public bool isOnGround;
    //public float jumpForce = 20;
    //public Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        //playerRb = GetComponent<Rigidbody>();
        upgradeScreen.SetActive(false);
        inGameUI.SetActive(false);
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

        if(Input.GetKeyDown(KeyCode.Q))
        {
            if(upgradeScreenOpen == false)
            {
                upgradeScreenOpen = true;
            }
            else
            {
                upgradeScreenOpen = false;
            }
        }

        if(gm.GetComponent<GameManager>().isGameActive && upgradeScreenOpen == true)
        {
            upgradeScreen.SetActive(true);
            inGameUI.SetActive(false);
            gm.GetComponent<GameManager>().isGameActive = false;
        }
        else if (upgradeScreenOpen == false)
        {
            upgradeScreen.SetActive(false);
            inGameUI.SetActive(true);
        }

        if (gm.isGameActive)
        {
            inGameUI.SetActive(true);
        }
        else
        {
            inGameUI.SetActive(false);
        }

        if(upgradeScreenOpen == true)
        {
            if(Input.GetKeyDown(KeyCode.B))
            {
                gm.GetComponent<GameManager>().points -= 10;
                laser.GetComponent<LaserMove>().laserStrength += 10;
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                gm.GetComponent<GameManager>().points -= 10;
                laser.GetComponent<LaserMove>().laserCooldown -= 0.2f;
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                gm.GetComponent<GameManager>().points -= 10;
                speed += 2;
            }
        }
    }

    //private void OnCollisonEnter(Collision collsion)
    //{
        //if(collsion.gameObject.CompareTag("Ground"))
        //{
            //isOnGround = true;
        //}
    //}
}
