using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : ClickableObject
{
    //----------------ATTRIBUTES------------------
    public enum CurrentOrientation {SOUTH, EAST, NORTH, WEST};
    public CurrentOrientation startOrientation;

    private bool currentOkay;
    private CurrentOrientation currentOrientation;

    private bool inRotation;
    private readonly float indent = 4f;
    private readonly float indentMax = 85f;

    public static int finalOrientations;
    private static int numberPaintings;


    //-----------------------------------------





    //----------------METHODS------------------


    //----------------RUNTIME----------

    //---Start is called before the first frame update
    public override void Start()
    {
        base.Start();

        this.currentOrientation = this.startOrientation;
        this.inRotation = false;
        this.currentOkay = false;
        if(numberPaintings == 0)
        {
            numberPaintings = GameObject.FindObjectsOfType<Painting>().Length;
        }
        CheckOrientation();

        Vector3 newRotation = this.transform.eulerAngles;
        newRotation.z = 90 * ((int)currentOrientation);
        this.transform.eulerAngles = newRotation;
    }

    //---Update is called once per frame
    void FixedUpdate()
    {

        if (inRotation)
        {
            if ( this.transform.eulerAngles.z % 90 < indentMax)
            { 
                Vector3 newRotation = this.transform.eulerAngles;
                newRotation.z += indent;
                this.transform.eulerAngles = newRotation;
            }
            else
            {
                Vector3 newRotation = this.transform.eulerAngles;
                newRotation.z += 90 - this.transform.eulerAngles.z % 90;
                if (newRotation.z == 360)
                {
                    newRotation.z = 0;
                }
                this.transform.eulerAngles = newRotation;
                inRotation = false;
            }
        }
    }

    //----------------AUTRES----------
    public void Rotate()
    {
        if(inRotation == false)
        {
            inRotation = true;
            currentOrientation = (CurrentOrientation) ( ( ( (int)currentOrientation) +1) %4 );
            CheckOrientation();
        }
    }

    public void CheckOrientation()
    {
        if (currentOrientation == CurrentOrientation.SOUTH)
        {
            finalOrientations++;
            this.currentOkay = true;
        }
        else if(currentOkay)
        {
            finalOrientations--;
            this.currentOkay = false;

        }
        //Debug.Log("Current score : " + finalOrientations );

        if (finalOrientations == numberPaintings)
        {
            AllPaintingsWthRightOrientation();
        }

    }

    public void AllPaintingsWthRightOrientation()
    {
        Game.catAfraid = true;
        GameObject.FindGameObjectWithTag("Cat").GetComponent<Cat>().BecomeAngry();

    }


    public override void OnClick()
    {

        Rotate();

    }
    //--------------------------------

    //-----------------------------------------
}
