using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishSwimAway : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fishTask;
    private Vector3 pos;
    private Vector3 startingPos = Vector3.one;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time < 3.0 && startingPos == Vector3.one)
        {
            Debug.Log("got starting pos");
            startingPos = fishTask.transform.position;
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("swimming");
            pos = fishTask.transform.position;
            fishTask.transform.position = new Vector3(pos.x + 0.1f, pos.y,pos.z);
        }
        else if (Input.GetKeyDown(KeyCode.G));
        {
            Debug.Log("swimmingEnd");
            fishTask.transform.position = startingPos;
        }

    }
}
