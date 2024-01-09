using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : ClickableObject
{
    //----------------ATTRIBUTES------------------

    //-----------------------------------------
    //----------------METHODS------------------
    //----------------RUNTIME----------

    //----------------AUTRES----------

    public override void OnClick()
    {
        if (Game.hasHat && Game.hasScarf && Game.hasSweater && Game.hasBoots)
        {
            PopUpManager.PopUpMessageButton("À moi la neige ! ", PopUpManager.PopUpImage.KIMIHAPPY, "Rester", "Sortir", AcceptMethod.TypeAcceptMethod.GOOUT);
        }
        else
        {
            string missingItems = "Il me manque ";
            if (!Game.hasHat)
            {
                missingItems += "mon chapeau, ";
            }
            if (!Game.hasScarf)
            {
                missingItems += "mon écharpe, ";
            }
            if (!Game.hasSweater)
            {
                missingItems += "mon pull, ";
            }
            if (!Game.hasBoots)
            {
                missingItems += "mes bottes, ";
            }
            missingItems += "pour pouvoir sortir.";
            PopUpManager.PopUpMessage(missingItems, PopUpManager.PopUpImage.KIMITHINKING);
        }
        
    }

    //--------------------------------
    //-----------------------------------------
}
