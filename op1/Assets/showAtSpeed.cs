using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showAtSpeed : MonoBehaviour
{
    public GameObject controllerPos;
    public float speedlimit = 0.005f;

    private Vector3 priorPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = controllerPos.transform.position;
        float speed = Vector3.Distance(currentPos, priorPos);
        Debug.Log(speed);
        priorPos = currentPos;

        if (Math.Abs(speed) > speedlimit) 
        {
            transform.position = new Vector3(0.75f, 2f, -2.77f);
        }
        else
        {
            transform.position = new Vector3(0f,-100f,0f);
        }
    }
}
