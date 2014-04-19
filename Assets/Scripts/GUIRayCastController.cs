using UnityEngine;
using System.Collections;

public class GUIRayCastController : MonoBehaviour{

    public GUIRenderer renderClass;

    private bool isInText = false; 
    void Update()
    {
        manageControllerInput();
        checkRayInput();
        updateRender();

    }

    private void manageControllerInput()
    {
        if (Input.GetAxis("A_Button") > 0)
        {
            Debug.Log("A_Button!");

        }


        if (Input.GetAxis("B_Button") > 0)
        {
            Debug.Log("Back!");
            if (isInText)
            {
                isInText = false;
            }
        }
             

        if (Input.GetAxis("X_Button") > 0)
        {
            Debug.Log("Select");

        }

        if (Input.GetAxis("Xbox360ControllerTriggers") > 0)
        {
            Debug.Log("Triggerer" + (Input.GetAxis("Xbox360ControllerTriggers")));
        }
    }

    private void checkRayInput()
    {
        Ray screenCamRay = gameObject.camera.ScreenPointToRay(new Vector2(Screen.width * 0.3f, Screen.height * 0.5f));
        RaycastHit hit;
        if(!isInText)
        {
            if (Physics.Raycast(screenCamRay, out hit))
            {
                if (hit.collider.gameObject.tag == "Info")
                {

                    GetInformation infoBox = hit.collider.gameObject.GetComponent<GetInformation>();
                    renderClass.updateInput(infoBox.getheadLine1(), "Auswählen", infoBox.getheadInfoText(), infoBox.getIcon());

                    if (Input.GetAxis("A_Button") > 0)
                    {
                        Debug.Log("A_Button!");
                        isInText = true;
                    }
                }

                else
                {
                    if (!isInText)
                    {
                        renderClass.stopDrawing();
                    }
                }
            }
        }
        
    }

    private void updateRender()
    {
        renderClass.setIsInText(isInText);
    }
}
