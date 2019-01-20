using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resizeWithLeftController : MonoBehaviour
{
    public GameObject task;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            task.transform.localScale += new Vector3(0.1F, 0.1f, 0.1f);
        } else if (Input.GetKeyDown(KeyCode.S))
        {
            task.transform.localScale -= new Vector3(0.1F, 0.1f, 0.1f);
        }
    }
}
