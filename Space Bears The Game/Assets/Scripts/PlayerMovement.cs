using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 8;
    Vector3 velocity;
    public float gravity = -9.81f;
    public GameManager gm;
    public GameObject upgradeScreen;
    public bool upgradeScreenOpen = false;
    public GameObject inGameUI;
    public GameObject laser;
    public bool deathStatus = false;
    public float b = 1;
    public float e = 1;
    public float r = 1;
    public TextMeshProUGUI bText;
    public TextMeshProUGUI eText;
    public TextMeshProUGUI rText;
    //public GameObject death;
    //public bool isOnGround;
    //public float jumpForce = 20;
    //public Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        //playerRb = GetComponent<Rigidbody>();
        speed = 8;
        upgradeScreen.SetActive(false);
        inGameUI.SetActive(false);
        laser.GetComponent<LaserMove>().laserStrength = 10;
        laser.GetComponent<LaserMove>().laserCooldown = 1;
        //death.SetActive(false);
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

        if (b == 1)
        {
            bText.text = "Attack 1-Increases attack damage a little-10 points";
        }
        else if (b == 2)
        {
            bText.text = "Attack 2-Increases attack damage a little-20 points";
        }
        else if (b == 3)
        {
            bText.text = "Attack 3-Increases attack damage a little-30 points";
        }
        else if (b == 4)
        {
            bText.text = "Attack 4-Increases attack damage a little-40 points";
        }
        else if (b == 5)
        {
            bText.text = "Attack 5-Increases attack damage a little-50 points";
        }

        if (e == 1)
        {
            eText.text = "Fire Rate 1-Increases the player's fire rate a little-10 points";
        }
        else if (e == 2)
        {
            eText.text = "Fire Rate 2-Increases the player's fire rate a little-20 points";
        }
        else if (e == 3)
        {
            eText.text = "Fire Rate 3-Increases the player's fire rate a little-30 points";
        }
        else if (e == 4)
        {
            eText.text = "Fire Rate 4-Increases the player's fire rate a little-40 points";
        }
        else if(e == 5)
        {
            eText.text = "Fire Rate 5-Increases the player's fire rate a little-50 points";
        }

        if (r == 1)
        {
            rText.text = "Speed 1-Increases the player's speed a little-10 points";
        }
        else if (r == 2)
        {
            rText.text = "Speed 2-Increases the player's speed a little-20 points";
        }
        else if (r == 3)
        {
            rText.text = "Speed 3-Increases the player's speed a little-30 points";
        }
        else if (r == 4)
        {
            rText.text = "Speed 4-Increases the player's speed a little-40 points";
        }
        else if (r == 5)
        {
            rText.text = "Speed 5-Increases the player's speed a little-50 points";
        }

        if (gm.GetComponent<GameManager>().isGameActive && upgradeScreenOpen == true)
        {
            upgradeScreen.SetActive(true);
            inGameUI.SetActive(false);
            gm.GetComponent<GameManager>().isGameActive = false;
        }
        else if (upgradeScreenOpen == false)
        {
            upgradeScreen.SetActive(false);
            inGameUI.SetActive(true);
            gm.GetComponent<GameManager>().isGameActive = true;
        }

        if (gm.isGameActive)
        {
            inGameUI.SetActive(true);
        }
        else
        {
            inGameUI.SetActive(false);
        }

        if (upgradeScreenOpen == true)
        {
            if(Input.GetKeyDown(KeyCode.B) && gm.GetComponent<GameManager>().points >= (b * 10))
            {
                gm.GetComponent<GameManager>().points -= (b * 10);
                laser.GetComponent<LaserMove>().laserStrength += 5;
                b += 1;
            }
            else if (Input.GetKeyDown(KeyCode.E) && gm.GetComponent<GameManager>().points >= (e * 10))
            {
                gm.GetComponent<GameManager>().points -= (e * 10);
                laser.GetComponent<LaserMove>().laserCooldown -= 0.2f;
                e += 1;
            }
            else if (Input.GetKeyDown(KeyCode.R) && gm.GetComponent<GameManager>().points >= (r * 10))
            {
                gm.GetComponent<GameManager>().points -= (r * 10);
                speed += 2;
                r += 1;
            }
        }

        if(deathStatus)
        {
            PlayerDie();
        }
    }

    public void PlayerDie()
    {
        //death.SetActive(true);
        //DONT DELETE THIS
        //SceneManager.LoadScene("Death");
    }

    //private void OnCollisonEnter(Collision collsion)
    //{
        //if(collsion.gameObject.CompareTag("Ground"))
        //{
            //isOnGround = true;
        //}
    //}
}
