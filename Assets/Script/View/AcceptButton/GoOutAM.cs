using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoOutAM : AcceptMethod
{
    //----------------ATTRIBUTES------------------

    //-----------------------------------------
    //----------------METHODS------------------
    //----------------RUNTIME----------


    //----------------AUTRES----------

    public override void Accept()
    {
        //CHANGER DE SCENE
        UnityEngine.SceneManagement.SceneManager.LoadScene("Victory");
    }

    //--------------------------------
    //-----------------------------------------
}
