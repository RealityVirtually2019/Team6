using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showVFXonEnter : MonoBehaviour
{
    public GameObject fireworks;

    public GameObject swimmingFish;
    // Start is called before the first frame update
    void Start()
    {
        fireworks.transform.position = new Vector3(0,-100,0);   
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            fireworks.transform.position = new Vector3(0,0,0);
  
        } else if (Input.GetKeyDown(KeyCode.O))
        {
            fireworks.transform.position = new Vector3(0,-100,0);   
          
        }
        
    }
}
