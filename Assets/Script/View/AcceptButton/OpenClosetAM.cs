using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClosetAM : AcceptMethod
{
    //----------------ATTRIBUTES------------------






    //-----------------------------------------
    //----------------METHODS------------------
    //----------------RUNTIME----------



    //----------------AUTRES----------

    public override void Accept()
    {
        Game.hasSweater = true;
        Game.CloseMenu();
        PopUpManager.PopUpMessage("Mon pull préféré ! Au moins je n'aurais pas froid dehors !", PopUpManager.PopUpImage.KIMIHAPPY);
        CharacterPlayer.ShowSweater();
        //Game.OpenSweaterGame();
    }

    //--------------------------------
    //-----------------------------------------
}
