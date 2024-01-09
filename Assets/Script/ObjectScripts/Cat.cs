using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : ClickableObject
{
    //----------------ATTRIBUTES------------------

    Animator animator;

    //-----------------------------------------
    //----------------METHODS------------------
    //----------------RUNTIME----------

    public void Awake()
    {
        animator = this.GetComponent<Animator>();
        animator.Play("CatSleeping");
    }

    public void OnEnable()
    {
        if (Game.catAfraid)
        {
            if (Game.hasScarf)
            {
                this.GetComponent<Animator>().Play("CatAngryScarfless");
            }
            else
            {
                this.GetComponent<Animator>().Play("CatAngry");
            }
            
        }

    }

    //----------------AUTRES----------

    public override void OnClick()
    {
        if(!Game.catAfraid)
        {
            PopUpManager.PopUpMessage("Mon écharpe ! Mais Charlie dort dessus ! Il faudrait que j'arrive à le distraire pour la récupérer.", PopUpManager.PopUpImage.CHARLIE);
}
        else if (!Game.hasScarf)
        {
            PopUpManager.PopUpMessageButton("Charlie est occupé avec les tableaux, je devrais essayer de prendre mon écharpe...", PopUpManager.PopUpImage.KIMITHINKING, "Laisser", "Prendre", AcceptMethod.TypeAcceptMethod.TAKESCARF);
        }
        else
        {
            PopUpManager.PopUpMessage("Charlie devrait se calmer sous peu.", PopUpManager.PopUpImage.CHARLIE);

        }
    }

    public void BecomeAngry()
    {
        animator.Play("CatAngry");
    }

    public void BecomeScarfless()
    {

        animator.Play("CatAngryScarfless");
    }

    //--------------------------------
    //-----------------------------------------
}
