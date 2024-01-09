using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boot : ClickableObject
{

    //----------------ATTRIBUTES------------------

    public bool isLeftBoot;

    //-----------------------------------------
    //----------------METHODS------------------
    //----------------RUNTIME----------
    //----------------AUTRES----------

    public override void OnClick()
    {
        if(isLeftBoot)
        {
            PopUpManager.PopUpMessageButton("Une botte ! Je l'avais mise sous le sapin, c'est vrai ! ", PopUpManager.PopUpImage.KIMIHAPPY, "Laisser", "Prendre", AcceptMethod.TypeAcceptMethod.TAKELEFTBOOT);
        }
        else
        {
            PopUpManager.PopUpMessageButton("Bah, c'est une botte ? Comment elle s'est retrouvée ici ? ", PopUpManager.PopUpImage.KIMITHINKING, "Laisser", "Prendre", AcceptMethod.TypeAcceptMethod.TAKERIGHTBOOT);
        }

    }

    //--------------------------------
    //-----------------------------------------
}
