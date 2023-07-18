using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class RemoteLaserTrigger : MonoBehaviour
{
    public GameObject laserGun;
    public Vector3 pos;
    public GameObject laserPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        pos = new Vector3(laserGun.transform.position.x + 0.5f, laserGun.transform.position.y + 0.2f, laserGun.transform.position.z + 1);
        Instantiate(laserPrefab, pos, laserGun.transform.rotation);
    }
}
