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
    public float value = 1;
    private float count = 0;
    public GameObject laserPrefab;
    public float laserStrength;
    public float attackAnimation;
    public float runAnimationHolder;
    public GameObject explosionParticle;

    public AudioSource roarPlayer;

    // Start is called before the first frame update
    void Start()
    {
        laserStrength = laserPrefab.GetComponent<LaserMove>().laserStrength;
        runAnimationHolder = 0;
        gm = FindObjectOfType<GameManager>();
        roarPlayer = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        laserStrength = laserPrefab.GetComponent<LaserMove>().laserStrength;

        if (gameObject.transform.position.y <= 1)
        {
            if (count == 0)
            {
                StartCoroutine(DeathAnimation());
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && damageDone == 0 && health > 0)
        {
            attackAnimation = Random.Range(1, 5);
            if(attackAnimation == 4)
            {
                GetComponent<Animator>().SetBool("Attack5", true);
            }
            else if(attackAnimation == 3)
            {
                GetComponent<Animator>().SetBool("Attack3", true);
            }
            else if (attackAnimation == 2)
            {
                GetComponent<Animator>().SetBool("Attack2", true);
            }
            else if (attackAnimation == 1)
            {
                GetComponent<Animator>().SetBool("Attack1", true);
            }
            gm.LoseHealth();
            StartCoroutine(RechargeTime());
            damageDone = 1;
        }
        else if (other.CompareTag("Laser"))
        {
            Destroy(other.gameObject);
            health -= laserStrength;
            runAnimationHolder = 1;
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
        yield return new WaitForSeconds(1);
        damageDone = 0;
        runAnimationHolder = 0;
    }

    IEnumerator HitAnimation()
    {
        yield return new WaitForSeconds(0.5f);
        runAnimationHolder = 0;
    }
    IEnumerator DeathAnimation()
    {
        roarPlayer.Stop();
        count++;
        gm.GetComponent<GameManager>().points += value;
        yield return new WaitForSeconds(5);
        FindObjectOfType<SpawnManager>().livingBears--;
        Instantiate(explosionParticle, transform.position, transform.rotation);
        Destroy(gameObject);
        count = 0;
    }
}
