using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsHide : MonoBehaviour
{
    public GameObject instructions;
    public bool on;

    // Start is called before the first frame update
    void Start()
    {
        instructions.SetActive(false);
        on = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(on && Input.GetKeyDown(KeyCode.H))
        {
            instructions.SetActive(false);
            on = false;
        }
        else if (!on && Input.GetKeyDown(KeyCode.H))
        {
            instructions.SetActive(true);
            on = true;
        }
    }
}
