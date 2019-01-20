using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subtitleToggler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.N))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -2.6502f);
        } else if (Input.GetKeyDown(KeyCode.M))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -2.83f);
        }

        
    }
}
