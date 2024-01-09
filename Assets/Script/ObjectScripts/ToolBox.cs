using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolBox : ClickableObject
{
    //----------------ATTRIBUTES------------------

    //-----------------------------------------
    //----------------METHODS------------------
    //----------------RUNTIME----------

    public void Awake()
    {

        GameObject.FindGameObjectWithTag("ToolBox").SetActive(true);
    }

    //----------------AUTRES----------

    public override void OnClick()
    {
        if (Game.showerTaken)
        {
            PopUpManager.PopUpMessageButton("Je pourrais prendre ma boîte à outil pour régler les problèmes de ventilation de ma salle de bain...", PopUpManager.PopUpImage.KIMITHINKING,"Laisser", "Prendre", AcceptMethod.TypeAcceptMethod.TAKETOOLBOX);
        }
        else
        {
            PopUpManager.PopUpMessage("Ma boîte à outil, toujours utile de la savoir à portée de main ! ", PopUpManager.PopUpImage.KIMIHAPPY);
        }
    }
}
