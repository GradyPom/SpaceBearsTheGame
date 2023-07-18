using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> spawnLocations;
    public GameObject bearBrown;
    public GameObject bearBlack;
    public GameObject bearPolar;

    public int waveNumber = 0;
    public int livingBears = 0;
    public float waveCD = 5;
    public float currentWaveCD;

    // Start is called before the first frame update
    void Start()
    {
        currentWaveCD = waveCD;
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
                spawnWave(waveNumber);
                currentWaveCD = waveCD;
            }

        }
    }

    void spawnWave(int num)
    {
        if (num == 1)
        {
            for (int i = 1 ; i<=3; i++)
            {
                Instantiate(bearBrown, spawnLocations[Random.Range(0,spawnLocations.Count)].transform.position,bearBlack.transform.rotation);
            }
        }

        if (num == 2)
        {
            for (int i = 1; i <= 3; i++)
            {
                Instantiate(bearBlack, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }

        if (num == 3)
        {
            for (int i = 1; i <= 3; i++)
            {
                Instantiate(bearPolar, spawnLocations[Random.Range(0, spawnLocations.Count)].transform.position, bearBlack.transform.rotation);
            }
        }
    }
}   
