using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetecter : MonoBehaviour
{
    public GameManager gm;
    private float damageDone = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && damageDone == 0)
        {
            gm.LoseHealth();
            damageDone = 1;
        }
    }
}
