using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeScarfAM : AcceptMethod
{

    //----------------ATTRIBUTES------------------

    //-----------------------------------------
    //----------------METHODS------------------
    //----------------RUNTIME----------

    //----------------AUTRES----------

    public override void Accept()
    {
        Game.hasScarf = true;
        Game.CloseMenu();
        GameObject.FindGameObjectWithTag("Cat").GetComponent<Cat>().BecomeScarfless();
        CharacterPlayer.ShowScarf();
    }

    //--------------------------------
    //-----------------------------------------
}
