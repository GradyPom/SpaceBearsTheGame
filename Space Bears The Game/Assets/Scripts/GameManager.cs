using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int health;
    public GameObject[] lifeBar;
    private int damageDone = 0;
    public bool isGameActive;
    public float points;
    public TextMeshProUGUI pointsText;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        health = 10;
        points = 0;
        damageDone = 0;
        StartGame();
    }

    public void StartGame()
    {
        for (int i = 0; i < 10; i++)
        {
            lifeBar[i].gameObject.SetActive(true);
        }
        isGameActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            isGameActive = false;
            player.GetComponent<PlayerMovement>().deathStatus = true;
        }

        //DELETE WHEN THERE ARE ENOUGH BEARS TO TEST
        if (Input.GetKeyDown(KeyCode.V))
        {
            points += 10;
        }

        pointsText.text = "Points: " + points;
    }

    public void LoseHealth()
    {
        for(int i = 9; i > -1; i--)
        {
            if (health == i + 1 && damageDone < 1)
            {
                lifeBar[i].gameObject.SetActive(false);
                health -= 1;
                damageDone++;
            }
        }
        damageDone = 0;
    }
}
