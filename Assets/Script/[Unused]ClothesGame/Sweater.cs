using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sweater : ClickableObject
{
    //----------------ATTRIBUTES------------------

    public int size;

    public bool isSweater;


    public Vector3 newLocalPosition;
    public bool inMove;

    //--Rotation Shake
    private bool isShaking;
    private int tickShake;
    private bool shakeRotation;
    private readonly static float shakeIndent = 0.15f;
    private readonly static float maxShakeZ = 5f;
    private readonly static int maxTickShake = 5000;

    //-----------------------------------------
    //----------------METHODS------------------
    //----------------RUNTIME----------
    public override void Start()
    {
        base.Start();
        this.newLocalPosition = this.transform.localPosition;
    }
    private void FixedUpdate()
    {
        if(isShaking)
        {
            if(tickShake-- > 0)
            {
                if(shakeRotation)
                {
                    if(this.transform.rotation.eulerAngles.z > maxShakeZ)
                    {
                        shakeRotation = false;
                    }
                    else
                    {
                        Vector3 newRot = transform.rotation.eulerAngles;
                        newRot.z += shakeIndent;
                        transform.rotation.eulerAngles.Set(newRot.x, newRot.y, newRot.z);
                    }
                }
                else
                {
                    if (this.transform.rotation.eulerAngles.z < -maxShakeZ)
                    {
                        shakeRotation = true;
                    }
                    else
                    {
                        Vector3 newRot = transform.rotation.eulerAngles;
                        newRot.z -= shakeIndent;
                        transform.rotation.eulerAngles.Set(newRot.x, newRot.y, newRot.z);

                    }
                }
            }
            else
            {
                isShaking = false; 
                Quaternion newRot = transform.rotation;
                newRot.z = 0;
                transform.rotation = newRot;
            }
        }
    }





    private void Update()
    {
        if(inMove)
        {
            //Make smooth move
            inMove = false;
            this.transform.localPosition = this.newLocalPosition;
        }

    }
    //----------------AUTRES----------

    public void ShakeError()
    {
        Debug.Log("ERROR CAN'T PLACE");
        this.isShaking = true;
        this.tickShake = maxTickShake;
    }
    public void MoveTo(Vector3 newLocalPosition)
    {
        //Debug.Log(this.name + " move to " + newLocalPosition);
        this.newLocalPosition = newLocalPosition;
            inMove = true;
    }

    public override void OnClick()
    {
        int currentColumnIndex = this.GetComponentInParent<ColumnClothes>().indexColumn;
        GameObject topClothesObject = ClothesGame.GetTopClothes(currentColumnIndex);
            //Debug.Log(this.name + " is clicked");
        if (ClothesGame.selectedClothes == null)
        {
            if (topClothesObject != null)
            {
                ClothesGame.SetSelectedClothes(topClothesObject);
            }
        }
        else if (currentColumnIndex == ClothesGame.selectedColumnIndex)
        {
            ClothesGame.UnselectClothes();
            if (topClothesObject != null)
            {
                ClothesGame.SetSelectedClothes(topClothesObject);
            }
        }
        else 
        {
            ClothesGame.SelectedClothesToColumn(this.GetComponentInParent<ColumnClothes>().indexColumn);
        }

    }

    public void GetSelected()
    {
        //Debug.Log(this.name + " is selected");
        
        this.GetComponent<SpriteRenderer>().color = Color.black;
    }

    public void GetUnselected()
    {
        //Debug.Log(this.name + " is unselected");
        this.GetComponent<SpriteRenderer>().color = Color.white;
    }


    //--------------------------------
    //-----------------------------------------
}
