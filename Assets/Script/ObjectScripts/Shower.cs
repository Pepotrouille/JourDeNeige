using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shower : ClickableObject
{

    public override void OnClick()
    {
        //Debug.Log("OKAY");
        if(Game.showerTaken)
        {
            PopUpManager.PopUpMessage("Ne gaspillons pas l'eau...", PopUpManager.PopUpImage.KIMITHINKING);
        }
        else
        {
            PopUpManager.PopUpMessageButton("Prendre une douche ?", PopUpManager.PopUpImage.SHOWERHEAD, "Non", "Oui", AcceptMethod.TypeAcceptMethod.TAKESHOWER);
        }
        
    }
}
