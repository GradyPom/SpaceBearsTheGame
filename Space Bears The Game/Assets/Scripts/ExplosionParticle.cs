using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionParticle : MonoBehaviour
{
    public AudioSource bearExplosion; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Explosion());
    }

    IEnumerator Explosion()
    {
        bearExplosion.Play();
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
