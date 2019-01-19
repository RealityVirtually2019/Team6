using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highlilghtPointer : MonoBehaviour {

    Highlighter currentTarget;
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            var highlighter = hit.transform.GetComponent<Highlighter>();
            setTarget(highlighter);
        }
	}

    void setTarget(Highlighter h)
    {
        if(h != currentTarget)
        {
            //make sure null isnt passed
            if(h != null)
                h.setHighlight(true);
            if(currentTarget != null)
                currentTarget.setHighlight(false);


            currentTarget = h;
        }
    }
}
