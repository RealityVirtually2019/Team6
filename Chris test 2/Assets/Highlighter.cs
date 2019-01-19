using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlighter : MonoBehaviour {

    public GameObject highlightModel;

	public void setHighlight(bool isHighlight)
    {
        highlightModel.SetActive(isHighlight);
    }
}
