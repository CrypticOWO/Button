using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check for mouse buttons being pressed
        if (Input.GetMouseButtonDown(0))        //If left mouse button is pressed
        {
            Debug.Log("Left Click");
        }
        if (Input.GetMouseButtonDown(1))        //If right mouse button is pressed
        {
            Debug.Log("Right Click");
        }
        if (Input.GetMouseButtonDown(2))        //If middle mouse button is pressed
        {
            Debug.Log("Middle Click");
        }
    }
}
