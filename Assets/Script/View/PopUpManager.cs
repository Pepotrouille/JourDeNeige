using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpManager : MonoBehaviour
{
    public enum PopUpImage {KIMIHAPPY, KIMISURPRISED, KIMITHINKING, SHOWERHEAD, CHARLIE }

    static Transform parent;

    private void Start()
    {
        parent = this.transform;
    }
    public static void PopUpMessage(string message, PopUpImage image)
    {
        if(!Game.inMenu)
        {
            GameObject newPopUp = Canvas.Instantiate(Resources.Load<GameObject>("Prefabs/UIPopUp"), parent);
            newPopUp.GetComponent<PopUpScript>().SetPopUp(message, image);
            Game.SetMenu(newPopUp);
        }
        
    }

    public static void PopUpMessageButton(string message, PopUpImage image, string cancelMessage, string acceptMessage, AcceptMethod.TypeAcceptMethod type)
    {
        if (!Game.inMenu)
        {
            GameObject newPopUp = Canvas.Instantiate(Resources.Load<GameObject>("Prefabs/UIPopUpButton"), parent);
            newPopUp.GetComponent<PopUpButtonScript>().SetPopUp(message, image, cancelMessage, acceptMessage, type);
            
            //AcceptMethodClass acceptMethod = popup.AddComponent<T>();
            Game.SetMenu(newPopUp);
        }
    }
}
