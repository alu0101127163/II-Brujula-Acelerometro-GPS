using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    	RectTransform rect = GetComponent<RectTransform>();

    	rect.transform.Rotate(0.0f, -Input.compass.trueHeading, 0.0f, Space.Self);       
    }
}
