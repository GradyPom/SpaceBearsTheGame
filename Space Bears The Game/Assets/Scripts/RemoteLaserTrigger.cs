using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using static UnityEngine.Rendering.DebugUI;

public class RemoteLaserTrigger : MonoBehaviour
{
    public GameObject laserGun;
    public Vector3 pos;
    public GameObject laserPrefab;
    public float cooldown;
    public float laserShot = 0;
    public GameObject player;
    public Transform shootPoint;
    public GameObject shoot;
    //public ParticleSystem gunParticle;

    // Start is called before the first frame update
    void Start()
    {
        //gunParticle.Stop();
        laserGun = GameObject.Find("Player Body/Main Camera/Laser Gun");
        shoot = GameObject.Find("Player Body/Main Camera/Laser Gun/Shoot Point");
        shootPoint = GameObject.Find("Player Body/Main Camera/Laser Gun/Shoot Point").transform;
        player = GameObject.Find("Player Body");
    }

    // Update is called once per frame
    void Update()
    {
        cooldown = laserPrefab.GetComponent<LaserMove>().laserCooldown;
    }

    private void OnMouseDown()
    {
        if (laserShot == 0 && laserGun.GetComponent<GunShoot>().zoom)
        {
            //pos = new Vector3(laserGun.transform.position.x - 1, laserGun.transform.position.y + 0.2f, laserGun.transform.position.z + 1);
            //pos = new Vector3(laserGun.transform.position.x, laserGun.transform.position.y, laserGun.transform.position.z + 1);
            pos = new Vector3(shootPoint.transform.position.x, shootPoint.transform.position.y, shootPoint.transform.position.z);
            Instantiate(laserPrefab, shootPoint.transform.position, shootPoint.transform.rotation);
            //gunParticle.Play();
            StartCoroutine(LaserCooldown());
            //else if (player.transform.rotation.y < 0)
            //{
                //pos = new Vector3(player.transform.position.x, laserGun.transform.position.y, player.transform.position.z - 1);
                //Instantiate(laserPrefab, pos, laserGun.transform.rotation);
                //StartCoroutine(LaserCooldown());
            //}
        }
        else if(laserShot == 0 && !laserGun.GetComponent<GunShoot>().zoom)
        {
            pos = new Vector3(laserGun.transform.position.x, laserGun.transform.position.y, laserGun.transform.position.z + 0.8f);
            Instantiate(laserPrefab, shootPoint.transform.position, laserGun.transform.rotation);
            //gunParticle.Play();
            StartCoroutine(LaserCooldown());
        }
    }

    IEnumerator LaserCooldown()
    {
        laserShot = 1;
        yield return new WaitForSeconds(cooldown);
        laserShot = 0;
        //gunParticle.Stop();
    }
}
