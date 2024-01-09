using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenVentAM : AcceptMethod
{

    //----------------ATTRIBUTES------------------






    //-----------------------------------------
    //----------------METHODS------------------
    //----------------RUNTIME----------



    //----------------AUTRES----------

    public override void Accept()
    {
        Game.hasHat = true;
        GameObject.FindGameObjectWithTag("Vent").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Objects/Vent_Opened");
        Game.CloseMenu();
        PopUpManager.PopUpMessage("Mon chapeau ! Ohlala, comment il s'est retrouvé ici ? Un peu d'époussetage et il sera comme neuf !", PopUpManager.PopUpImage.KIMIHAPPY);
        CharacterPlayer.ShowHat();
    }

    //--------------------------------
    //-----------------------------------------
}
