using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class changeColorOnEnter : MonoBehaviour
{
    private Color pre = Color.red;
    private Color post = Color.green;
    Material m_Material;
    void Start()
    {
        m_Material = GetComponent<Renderer>().material;
        m_Material.color = pre;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            m_Material.color = pre;
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered");
        m_Material.color = post;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exited");
    }

}