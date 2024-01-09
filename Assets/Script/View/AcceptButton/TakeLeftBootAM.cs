using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeLeftBootAM : AcceptMethod
{
    //----------------ATTRIBUTES------------------






    //-----------------------------------------
    //----------------METHODS------------------
    //----------------RUNTIME----------



    //----------------AUTRES----------

    public override void Accept()
    {
        GameObject.Destroy(GameObject.FindGameObjectWithTag("LeftBoot"));
        Game.CloseMenu();
        Game.hasLeftBoot = true;
        if (Game.hasRightBoot)
        {
            Game.hasBoots = true;
            PopUpManager.PopUpMessage("C'est bon, j'ai mes bottes aux pieds !", PopUpManager.PopUpImage.KIMIHAPPY);
            CharacterPlayer.ShowBoots();
        }
    }

    //--------------------------------
    //-----------------------------------------
}
