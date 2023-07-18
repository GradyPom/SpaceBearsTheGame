using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    public GameObject laserPrefab;
    public Vector3 pos;

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
        pos = new Vector3(transform.position.x - 1, transform.position.y + 0.2f, transform.position.z + 1);
        Instantiate(laserPrefab, pos, transform.rotation);
    }
}
