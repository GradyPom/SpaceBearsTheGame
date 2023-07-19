using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    public GameObject laserPrefab;
    public Vector3 pos;
    public GameObject player;
    public bool zoom;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift) && !zoom)
        {
            transform.position = new Vector3(0.016f + player.transform.position.x, player.transform.position.y, player.transform.position.z);
            zoom = true;
        }
        else if(Input.GetKeyDown(KeyCode.LeftShift) && zoom)
        {
            transform.position = new Vector3(0.421f + player.transform.position.x, player.transform.position.y, .8500004f + player.transform.position.z);
            zoom = false;
        }
    }

    private void OnMouseDown()
    {
        pos = new Vector3(transform.position.x, transform.position.y + 0.2f, transform.position.z + 1);
        Instantiate(laserPrefab, pos, transform.rotation);
    }
}
