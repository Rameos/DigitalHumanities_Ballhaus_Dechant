using UnityEngine;
using System.Collections;

public class GUIRenderer : VRGUI{

    private bool isInText = false;
    private bool isDrawing = true; 
    public Texture2D iconInformation;
    public Texture2D backgroundText;
    public string headLine1;
    public string headLine2 = "Starten";

    private string informationText = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.";
    private Texture informationPicture;

    private float xElement;
    private float yElement;

    public float sizeicon = 128;

    public GUIStyle headLineInformationStyle;
    public GUIStyle inputSupportStyle;
    public GUIStyle informationTextStyle;


    public Texture2D AButton;
    public Texture2D BButton;
    public Texture2D XButton;
    public Texture2D YButton;


    void Start () {

        xElement = Screen.width * 0.4f;
        yElement = Screen.height * 0.5f;

	}
	
	void Update () {
	
	}

    public override void OnVRGUI()
    {


        if (isDrawing)
        {
            if (!isInText)
            {
                if (iconInformation != null)
                {
                    GUI.DrawTexture(new Rect(xElement, yElement, sizeicon, sizeicon), iconInformation);
                    GUI.Label(new Rect(xElement + sizeicon * 1.1f, yElement, 512, 128), headLine1, headLineInformationStyle);
                    GUI.DrawTexture(new Rect(xElement + sizeicon * 1.1f, yElement + 70, sizeicon * 0.45f, sizeicon * 0.45f), AButton);

                    GUI.Label(new Rect(xElement + sizeicon * 1.7f, yElement + 74, 512, 128), headLine2, inputSupportStyle);

                }
            }

            else
            {

                GUI.DrawTexture(new Rect(xElement * 0.5f, yElement * 0.5f, 1124, backgroundText.height), backgroundText);
                GUI.DrawTexture(new Rect(xElement * 1.78f, yElement * 0.525f, sizeicon * 0.9f, sizeicon * 0.9f), iconInformation);

                GUI.Label(new Rect(xElement * 0.55f, yElement * 0.57f, 512, 128), headLine1, headLineInformationStyle);
                GUI.Label(new Rect(xElement * 0.58f, yElement * 0.86f, 1024, 1024), informationText, informationTextStyle);


                GUI.DrawTexture(new Rect(xElement * 0.55f, yElement + backgroundText.height * 0.57f, sizeicon * 0.45f, sizeicon * 0.45f), BButton);
                GUI.Label(new Rect(xElement * 0.50f + BButton.width, yElement + backgroundText.height * 0.58f, 512, 128), "Zurück", inputSupportStyle);

            }
        }
    }

    public void updateInput(string headLine1Text, string headLine2Text,string text,Texture2D icon)
    {
        isDrawing = true; 
        this.headLine1 = headLine1Text;
        this.headLine2 = headLine2Text;
        this.informationText = text;
        this.iconInformation = icon;
    }

    public void stopDrawing()
    {
        isDrawing = false; 
    }
    
    public void setIsInText(bool isInText)
    {
        this.isInText = isInText;
    }
}
