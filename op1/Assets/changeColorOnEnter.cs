using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class changeColorOnEnter : MonoBehaviour
{
    private Color pre = Color.red;
    private Color post = Color.green;
    Material m_Material;

    private bool hasBeenGreened = false;
    void Start()
    {
        m_Material = GetComponent<Renderer>().material;
        m_Material.color = pre;
        hasBeenGreened = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            m_Material.color = pre;
            hasBeenGreened = false;

        }
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        
        m_Material.color = post;
        if (hasBeenGreened == false)
        {
            Debug.Log("ACQ out of 69");
            hasBeenGreened = true;
            AudioSource audd = GetComponent<AudioSource>();
            audd.Play();
        }
        
    }

}