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
            PopUpManager.PopUpMessage("Tiens, �a en fait de la bu�e.La ventilation doit avoir un probl�me", PopUpManager.PopUpImage.KIMITHINKING);
        }
    }

    //--------------------------------
    //-----------------------------------------
}
