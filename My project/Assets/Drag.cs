using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{

    //Variables for the game
    float startPosX;
    float startPosY;
    bool isBeingHeld;           //determine if object is being held

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isBeingHeld)            //if object is being held
        {
            Vector2 mousePos;       //create a vector called mousePos
            mousePos = Input.mousePosition;         //change the value of mousePos
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);           //change the value of mousePos
            gameObject.transform.localPosition = new Vector2(mousePos.x, mousePos.y);          //change the positon of the 
        }
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos;
            mousePos = Input.mousePosition;         //change the value of mousePos
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            isBeingHeld = true;
        }
        
    }

    void OnMouseUp()
    {
        isBeingHeld = false;
    }
}
