using UnityEngine;
using System.Collections;

public class XboxControllerInput : MonoBehaviour {

    int idOfMouseButton; 
	// Use this for initialization
	void Start () {
	
	}
	
	void Update () {
	

        //if(Input.GetAxis("Name of the Axis")>0)
        {
            //Do Fancy Stuff here
        }

        if(Input.GetKey(KeyCode.E))
        {
            // Do stuff
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            // Do stuff
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            // Do stuff
        }


        if(Input.GetMouseButtonDown(idOfMouseButton))
        {
            // Do stuff, when the Mousebutton is pressed
        }

        if (Input.GetMouseButton(idOfMouseButton))
        {
            // Do stuff, when the Mousebutton is everytime pressed 
        }

        if (Input.GetMouseButtonUp(idOfMouseButton))
        {
            // Do stuff
        }
	}
}
