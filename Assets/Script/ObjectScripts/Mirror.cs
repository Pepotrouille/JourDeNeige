using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : ClickableObject
{
    //----------------ATTRIBUTES------------------

    //-----------------------------------------
    //----------------METHODS------------------
    //----------------RUNTIME----------

    //----------------AUTRES----------

    public override void OnClick()
    {
        if (!Game.hasHat && Game.showerTaken)
        {
            PopUpManager.PopUpMessage("Tiens, ça en fait de la buée.La ventilation doit avoir un problème", PopUpManager.PopUpImage.KIMITHINKING);
        }
    }

    //--------------------------------
    //-----------------------------------------
}
