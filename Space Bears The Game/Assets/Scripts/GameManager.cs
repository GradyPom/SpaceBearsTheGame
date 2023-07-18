using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int health;
    public GameObject[] lifeBar;
    private int damageDone = 0;

    // Start is called before the first frame update
    void Start()
    {
        health = 10;
        for(int i = 0; i < 10; i++)
        {
            lifeBar[i].gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
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
