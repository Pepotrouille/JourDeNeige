using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnClothes : ClickableObject
{
    //----------------ATTRIBUTES------------------

    public int indexColumn;

    //-----------------------------------------
    //----------------METHODS------------------
    //----------------RUNTIME----------

    //----------------AUTRES----------

    public override void OnClick()
    {
        if (ClothesGame.selectedColumnIndex == this.indexColumn)
        {
            ClothesGame.UnselectClothes();
        }
        else if (ClothesGame.selectedColumnIndex != -1)
        {
            ClothesGame.SelectedClothesToColumn(indexColumn);
        }
        else
        {
            GameObject TopClothes = ClothesGame.GetTopClothes(indexColumn);
            if(TopClothes != null)
            {
                ClothesGame.SetSelectedClothes(TopClothes);
            }
        }
    }

    //--------------------------------
    //-----------------------------------------
}
