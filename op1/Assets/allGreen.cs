using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allGreen : MonoBehaviour
{
    public GameObject[] childrenList;
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        for (int i = 0; i < 68; i++)
        {
            if (childrenList[i].GetComponent<Material>().color == Color.green)
            {
                counter += 1;
            }
        }
        Debug.Log(counter);
        if (counter > 5)
        {
            Debug.Log("colo many");
        }
    }
}
