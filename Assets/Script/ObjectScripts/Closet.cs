using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closet : ClickableObject
{
    //----------------ATTRIBUTES------------------

    //-----------------------------------------
    //----------------METHODS------------------
    //----------------RUNTIME----------

    //----------------AUTRES----------

    public override void OnClick()
    {
        if (!Game.hasSweater)
        {
            PopUpManager.PopUpMessageButton("Mon pull devrait être quelque part dans le plac... oh non, ce bazar !", PopUpManager.PopUpImage.KIMISURPRISED, "Plus tard", "Ranger", AcceptMethod.TypeAcceptMethod.OPENCLOSET);
        }
        else
        {
            PopUpManager.PopUpMessage("Ca fait du bien de voir cette armoire enfin rangée !", PopUpManager.PopUpImage.KIMIHAPPY);

        }
    }

    //--------------------------------
    //-----------------------------------------
}
