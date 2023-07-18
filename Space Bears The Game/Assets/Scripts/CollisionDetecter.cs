using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class CollisionDetecter : MonoBehaviour
{
    public GameManager gm;
    private float damageDone = 0;
    public float health = 20;

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
            StartCoroutine(RechargeTime());
            damageDone = 1;
        }
        else if (other.CompareTag("Laser"))
        {
            Destroy(other.gameObject);
            health -= 10;

            if (health <= 0)
            {
                GetComponent<Animator>().SetBool("Death", true);
                StartCoroutine(DeathAnimation());
            }
            else
            {
                GetComponent<Animator>().SetBool("Get Hit Front", true);
                StartCoroutine(HitAnimation());
            }
        }
    }
    IEnumerator RechargeTime()
    {
        yield return new WaitForSeconds(2);
        damageDone = 0;
    }

    IEnumerator HitAnimation()
    {
        yield return new WaitForSeconds(0.5f);
    }
    IEnumerator DeathAnimation()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
