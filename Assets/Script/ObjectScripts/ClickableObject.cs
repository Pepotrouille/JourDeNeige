using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{

    public virtual void Start()
    {

        //--Check ColliderBoxes

        if (this.GetComponent<BoxCollider>() == null)
        {
            this.gameObject.AddComponent<BoxCollider>();
        }
    }

    public virtual void OnClick()
    {

    }
}
