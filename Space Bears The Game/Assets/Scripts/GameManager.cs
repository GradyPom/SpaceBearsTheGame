using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int health;
    public GameObject[] lifeBar;
    private int damageDone = 0;
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        health = 10;
        for(int i = 0; i < 10; i++)
        {
            lifeBar[i].gameObject.SetActive(true);
        }
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            gameOver = true;
        }
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
