using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolBoxAM : AcceptMethod
{

    //----------------ATTRIBUTES------------------






    //-----------------------------------------
    //----------------METHODS------------------
    //----------------RUNTIME----------



    //----------------AUTRES----------

    public override void Accept()
    {
        Game.hasToolBox = true;
        GameObject.FindGameObjectWithTag("ToolBox").SetActive(false);
        Game.CloseMenu();
    }

    //--------------------------------
    //-----------------------------------------
}
