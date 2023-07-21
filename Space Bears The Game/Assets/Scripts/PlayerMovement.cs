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
    public float h = 1;
    public TextMeshProUGUI bText;
    public TextMeshProUGUI eText;
    public TextMeshProUGUI rText;
    public TextMeshProUGUI hText;
    //public GameObject death;
    //public bool isOnGround;
    //public float jumpForce = 20;
    //public Rigidbody playerRb;

    public AudioSource upgradePlayer;

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

        bText.text = "Attack " + b + "-Increases the player's attack a little-" + b + "0 points";

        hText.text = "Press P to spend " + h + "00 points to heal in the middle of a wave.";

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
        else
        {
            eText.text = "Fire Rate Maxed";
        }


        rText.text = "Speed " + r + "-Increases the player's speed a little-" + r + "0 points";
        

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
                upgradePlayer.Play();
            }
            else if (Input.GetKeyDown(KeyCode.E) && gm.GetComponent<GameManager>().points >= (e * 10) && e <= 4)
            {
                gm.GetComponent<GameManager>().points -= (e * 10);
                laser.GetComponent<LaserMove>().laserCooldown -= 0.2f;
                e += 1;
                upgradePlayer.Play();
            }
            else if (Input.GetKeyDown(KeyCode.R) && gm.GetComponent<GameManager>().points >= (r * 10))
            {
                gm.GetComponent<GameManager>().points -= (r * 10);
                speed += 2;
                r += 1;
                upgradePlayer.Play();
            }
            else if (Input.GetKeyDown(KeyCode.P) && gm.GetComponent<GameManager>().points >= (h * 100))
            {
                gm.StartGame();
                gm.GetComponent<GameManager>().points -= (h * 100);
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
        SceneManager.LoadScene("Death");
    }

    //private void OnCollisonEnter(Collision collsion)
    //{
        //if(collsion.gameObject.CompareTag("Ground"))
        //{
            //isOnGround = true;
        //}
    //}
}
