using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingBearBroadcast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<SpawnManager>().livingBears++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
