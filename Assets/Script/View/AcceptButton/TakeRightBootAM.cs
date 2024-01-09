using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeRightBootAM : AcceptMethod
{
    //----------------ATTRIBUTES------------------






    //-----------------------------------------
    //----------------METHODS------------------
    //----------------RUNTIME----------



    //----------------AUTRES----------

    public override void Accept()
    {
        GameObject.Destroy(GameObject.FindGameObjectWithTag("RightBoot"));
        Game.CloseMenu();
        Game.hasRightBoot = true;
        if (Game.hasLeftBoot)
        {
            Game.hasBoots = true;
            PopUpManager.PopUpMessage("C'est bon, j'ai mes bottes aux pieds !", PopUpManager.PopUpImage.KIMIHAPPY);
            CharacterPlayer.ShowBoots();
        }
    }

    //--------------------------------
    //-----------------------------------------
}
