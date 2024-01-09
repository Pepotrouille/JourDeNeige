using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vent : ClickableObject
{

    //----------------ATTRIBUTES------------------






    //-----------------------------------------
    //----------------METHODS------------------
    //----------------RUNTIME----------



    //----------------AUTRES----------

    public override void OnClick()
    {
        if(Game.hasHat)
        {
            PopUpManager.PopUpMessage("Je me demande vraiment comment mon chapeau est arrivé là...", PopUpManager.PopUpImage.KIMITHINKING);
        }
        else if(Game.showerTaken && Game.hasToolBox)
        {
            PopUpManager.PopUpMessageButton("Je peux essayer d'ouvrir la ventilation", PopUpManager.PopUpImage.KIMITHINKING, "Laisser", "Ouvrir", AcceptMethod.TypeAcceptMethod.OPENVENT);
        }
        else if (Game.showerTaken)
        {
            PopUpManager.PopUpMessage("Je crois que quelque chose bouche la ventilation. Il faudrait que je l'ouvre pour inspecter tout ça.", PopUpManager.PopUpImage.KIMITHINKING);
        }
    }
    //--------------------------------
    //-----------------------------------------
}
