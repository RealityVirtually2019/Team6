using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour {

    private Material matofobject;
    private Color col;

	// Use this for initialization
	void Start () {
        matofobject = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
        float vec = transform.position.y;
        if (vec >= 3)
        {
            col = Color.red;
        }
        else if(vec >= 2.5)
        {
            col = Color.yellow;
        }
        else if (vec >= 2)
        {
            col = Color.green;
        }
        else if (vec >= 1.5)
        {
            col = Color.blue;
        }
        else if (vec >= 1)
        {
            col = Color.magenta;
        }
        else
        {
            col = Color.black;
        }

        matofobject.color = col;

    }
}
