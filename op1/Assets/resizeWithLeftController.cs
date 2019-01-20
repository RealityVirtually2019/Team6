using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
public class resizeWithLeftController : MonoBehaviour
{
    public GameObject task;

    public GameObject otherController;
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
        else if (Input.GetKey(KeyCode.C))
            {
                task.transform.position = new Vector3(otherController.transform.position.x, otherController.transform.position.y + 0.75f, otherController.transform.position.z);
                task.transform.rotation = otherController.transform.rotation; 
            }
        
    }
}
