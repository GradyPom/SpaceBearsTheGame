using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> spawnLocations;
    public GameObject bearBrown;
    public GameObject bearBlack;
    public GameObject bearPolar;
    public GameObject bearBlue;
    public GameObject bearGhost;
    public GameObject bearCyborg;
    public GameManager gm;

    public int waveNumber = 0;
    public int livingBears = 0;
    public float waveCD = 5;
    public float currentWaveCD;

    // Start is called before the first frame update
    void Start()
    {
        Physics.bounceThreshold = 2;

        currentWaveCD = waveCD;
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (livingBears == 0)
        {
            currentWaveCD -= Time.deltaTime;

            if (currentWaveCD <= 0)
            {
                waveNumber += 1;
                gm.EndOfWave();
                spawnWave(waveNumber);
                currentWaveCD = waveCD;
            }

        }
    }

    void spawnWave(int num)
    {
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
            for (int i = 1; i <= 5; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 3; i++)
            {
                Instantiate(bearBlack, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
        else if (num == 8)
        {
            for (int i = 1; i <= 5; i++)
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
        }
        else if (num == 10)
        {
            for (int i = 1; i <= 5; i++)
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
        }
        else if (num == 11)
        {
            for (int i = 1; i <= 5; i++)
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
            for (int i = 1; i <= 1; i++)
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
            for (int i = 1; i <= 2; i++)
            {
                Instantiate(bearPolar, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
            for (int i = 1; i <= 3; i++)
            {
                Instantiate(bearBlue, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
    }
}   
