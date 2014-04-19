using UnityEngine;
using System.Collections;

public class GetInformation : MonoBehaviour
{


    public string headLine1;
    public string headLine2;
    public string informationText;
    public Texture2D icon;

    public string getheadLine1()
    {
        return headLine1;
    }


    public string getheadLine2()
    {
        return headLine2;
    }


    public string getheadInfoText()
    {
        return informationText;
    }


    public Texture2D getIcon()
    {
        return icon;
    }
}
