using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> spawnLocations;
    public GameObject bearBrown;
    public GameObject bearBlack;
    public GameObject bearPolar;
    public GameObject bearBlue;
    public GameObject bearGhost;
    public GameObject bearCyborg;
    public GameObject bearGold;
    public GameManager gm;
    public GameObject bossSpawn;
    public TextMeshProUGUI waveNumText;
    public float wave = 0;

    public int waveNumber = 0;
    public int livingBears = 0;
    public float waveCD = 5;
    public float currentWaveCD;

    public AudioSource wavePlayer;
    public bool soundPlayed;

    // Start is called before the first frame update
    void Start()
    {
        Physics.bounceThreshold = 2;

        currentWaveCD = waveCD;
        gm = FindObjectOfType<GameManager>();
        bossSpawn = GameObject.Find("Boss Spawn Loctaion");

        soundPlayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (livingBears == 0)
        {
            if (!(waveNumber == 0) && !soundPlayed)
            {
                wavePlayer.Play();
                soundPlayed = true;
            }
            currentWaveCD -= Time.deltaTime;

            if (currentWaveCD <= 0)
            {
                waveNumber += 1;
                gm.EndOfWave();
                spawnWave(waveNumber);
                currentWaveCD = waveCD;
                soundPlayed = false;
            }

        }

        waveNumText.text = "Wave: " + wave;
    }

    void spawnWave(int num)
    {
        wave = num;
        if (num == 1)
        {
            for (int i = 1 ; i <= 3; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0,spawnLocations.Count)].transform.position,bearBlack.transform.rotation);
            }
        }
        else if (num == 2)
        {
            for (int i = 1; i <= 5; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 3)
        {
            for (int i = 1; i <= 7; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 4)
        {
            for (int i = 1; i <= 5; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 2; i++)
            {
                Instantiate(bearBlack, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 5)
        {
            for (int i = 1; i <= 7; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 2; i++)
            {
                Instantiate(bearBlack, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 6)
        {
            for (int i = 1; i <= 5; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 3; i++)
            {
                Instantiate(bearBlack, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 7)
        {
            for (int i = 1; i <= 6; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 4; i++)
            {
                Instantiate(bearBlack, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 8)
        {
            for (int i = 1; i <= 6; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 3; i++)
            {
                Instantiate(bearBlack, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 1; i++)
            {
                Instantiate(bearPolar, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 9)
        {
            for (int i = 1; i <= 8; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 4; i++)
            {
                Instantiate(bearBlack, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 2; i++)
            {
                Instantiate(bearPolar, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 10)
        {
            for (int i = 1; i <= 5; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 4; i++)
            {
                Instantiate(bearBlack, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 3; i++)
            {
                Instantiate(bearPolar, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 11)
        {
            for (int i = 1; i <= 10; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 3; i++)
            {
                Instantiate(bearBlack, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 2; i++)
            {
                Instantiate(bearPolar, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 1; i++)
            {
                Instantiate(bearBlue, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 12)
        {
            for (int i = 1; i <= 5; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 4; i++)
            {
                Instantiate(bearBlack, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 2; i++)
            {
                Instantiate(bearPolar, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 3; i++)
            {
                Instantiate(bearBlue, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 12)
        {
            for (int i = 1; i <= 5; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 1; i++)
            {
                Instantiate(bearBlack, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 5; i++)
            {
                Instantiate(bearPolar, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 2; i++)
            {
                Instantiate(bearBlue, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 13)
        {
            for (int i = 1; i <= 10; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 1; i++)
            {
                Instantiate(bearPolar, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 4; i++)
            {
                Instantiate(bearBlue, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 14)
        {
            for (int i = 1; i <= 2; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 6; i++)
            {
                Instantiate(bearBlack, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 4; i++)
            {
                Instantiate(bearPolar, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 5; i++)
            {
                Instantiate(bearBlue, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 15)
        {
            for (int i = 1; i <= 6; i++) 
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 4; i++)
            {
                Instantiate(bearBlack, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 2; i++)
            {
                Instantiate(bearPolar, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 2; i++)
            {
                Instantiate(bearBlue, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 1; i++)
            {
                Instantiate(bearGhost, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 16)
        {
            for (int i = 1; i <= 2; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 10; i++)
            {
                Instantiate(bearPolar, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 2; i++)
            {
                Instantiate(bearBlue, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 2; i++)
            {
                Instantiate(bearGhost, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 17)
        {
            for (int i = 1; i <= 16; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 6; i++)
            {
                Instantiate(bearBlack, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 3; i++)
            {
                Instantiate(bearBlue, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 3; i++)
            {
                Instantiate(bearGhost, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 18)
        {
            for (int i = 1; i <= 6; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 8; i++)
            {
                Instantiate(bearBlack, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 3; i++)
            {
                Instantiate(bearPolar, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 3; i++)
            {
                Instantiate(bearBlue, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 4; i++)
            {
                Instantiate(bearGhost, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 19)
        {
            for (int i = 1; i <= 6; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 10; i++)
            {
                Instantiate(bearBlack, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 2; i++)
            {
                Instantiate(bearPolar, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 2; i++)
            {
                Instantiate(bearBlue, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 1; i++)
            {
                Instantiate(bearGhost, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 1; i++)
            {
                Instantiate(bearCyborg, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 20)
        {
            for (int i = 1; i <= 6; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 3; i++)
            {
                Instantiate(bearBlack, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 3; i++)
            {
                Instantiate(bearPolar, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 3; i++)
            {
                Instantiate(bearBlue, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 2; i++)
            {
                Instantiate(bearGhost, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 2; i++)
            {
                Instantiate(bearCyborg, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 21)
        {
            for (int i = 1; i <= 10; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 4; i++)
            {
                Instantiate(bearBlack, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 4; i++)
            {
                Instantiate(bearPolar, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 4; i++)
            {
                Instantiate(bearBlue, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 4; i++)
            {
                Instantiate(bearGhost, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 4; i++)
            {
                Instantiate(bearCyborg, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 22)
        {
            for (int i = 1; i <= 20; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 2; i++)
            {
                Instantiate(bearBlack, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 1; i++)
            {
                Instantiate(bearPolar, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 1; i++)
            {
                Instantiate(bearBlue, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 1; i++)
            {
                Instantiate(bearGhost, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 5; i++)
            {
                Instantiate(bearCyborg, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 23)
        {
            for (int i = 1; i <= 5; i++)
            {
                Instantiate(bearBlue, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 5; i++)
            {
                Instantiate(bearGhost, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 10; i++)
            {
                Instantiate(bearCyborg, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 24)
        {
            for (int i = 1; i <= 20; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 5; i++)
            {
                Instantiate(bearBlue, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 5; i++)
            {
                Instantiate(bearGhost, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 10; i++)
            {
                Instantiate(bearCyborg, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 25)
        {
            for (int i = 1; i <= 20; i++)
            {
                Instantiate(bearCyborg, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 1; i++)
            {
                Instantiate(bearGold, bossSpawn.transform.position, bearBlack.transform.rotation);
            }
        }
    }
}   
