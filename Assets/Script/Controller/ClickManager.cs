using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{


    //----------------ATTRIBUTES------------------




    //-----------------------------------------


    //----------------METHODS------------------


    //----------------RUNTIME----------

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Select"))
        {
            //Debug.Log("Click " + Camera.main.ScreenPointToRay(Input.mousePosition));
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 1000.0f))
            {
                //Debug.Log("You selected the " + hit.transform.name); // ensure you picked right object


                ClickableObject selectedObject = hit.transform.GetComponent<ClickableObject>();
                if(selectedObject != null)
                {
                    selectedObject.OnClick();
                }
            }
        }
    }
    //----------------AUTRES----------

    //--------------------------------

    //-----------------------------------------
}
