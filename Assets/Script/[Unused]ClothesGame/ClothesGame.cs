using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesGame : MonoBehaviour
{
    public GameObject[] ColumnsGOPublic;

    public GameObject[] Column0ClothesPublic;
    public GameObject[] Column1ClothesPublic;
    public GameObject[] Column2ClothesPublic;
    public GameObject[] Column3ClothesPublic;

    public static GameObject[] ColumnsGO;

    public static GameObject[] Column0Clothes;
    public static GameObject[] Column1Clothes;
    public static GameObject[] Column2Clothes;
    public static GameObject[] Column3Clothes;

    public static GameObject selectedClothes = null;
    public static GameObject[] selectedColumn = null;
    public static int selectedColumnIndex = -1;


    private void Start()
    {
        ColumnsGO = this.ColumnsGOPublic;

        Column0Clothes = this.Column0ClothesPublic;
        Column1Clothes = this.Column1ClothesPublic;
        Column2Clothes = this.Column2ClothesPublic;
        Column3Clothes = this.Column3ClothesPublic;
    }

    public static void SetSelectedClothes(GameObject clothes)
    {
        GameObject selectedColumnGO = null;
        try
        {
            selectedClothes = clothes;
            selectedColumnGO = clothes.transform.parent.gameObject;
            selectedClothes.GetComponent<Sweater>().GetSelected();

            selectedColumnIndex = selectedColumnGO.GetComponent<ColumnClothes>().indexColumn;
            Debug.Log("Selectedcolumnindex : " + selectedColumnIndex);
            selectedColumn = GetColumnFromIndex(selectedColumnIndex);
        }
        catch(Exception e)
        {
            Debug.Log("AAAAAAAAAAAAAAAA");
        }
        
        
    }

    public static void UnselectClothes()
    {
        selectedClothes.GetComponent<Sweater>().GetUnselected();
        selectedClothes = null;
        selectedColumn = null;
        selectedColumnIndex = -1;
    }

    public static void SelectedClothesToColumn(int indexColumn)
    {
        if(selectedClothes != null)
        {
            ClothesToColumn(selectedClothes, indexColumn);
        }
        
    }

    public static void ClothesToColumn(GameObject clothes, int indexColumn)
    {
        //Gérer sélection
        int validIndex = IsClothesPossibleInColumn(clothes, indexColumn);
        int i = 4;
        if (validIndex != -1)
        {
            GameObject[] column = GetColumnFromIndex(indexColumn);
            column[validIndex] = clothes;
            Debug.Log(validIndex);
            for (; i >= 0; i--)
            {
                if (column[i] != null)
                {
                    column[i] = null;
                    break;
                }
            }
            clothes.transform.SetParent(ColumnsGO[indexColumn].transform);
            clothes.GetComponent<Sweater>().MoveTo(new Vector3(0, (-2.5f + validIndex), -1));
            Debug.Log(validIndex);

            UnselectClothes();
        }
        else if (selectedClothes != null)
        {
            selectedClothes.GetComponent<Sweater>().ShakeError();
        }


    }

    public static int IsClothesPossibleInColumn(GameObject clothes, int indexColumn)
    {
        //Debug.Log("OKAY : " + clothes + " ; " + indexColumn);

        bool selectableClothes = false;
        int indexPossible = -1;

        //Debug.Log("Verif : " + GetTopClothes(selectedColumnIndex).name + " and " + clothes.name);

        //Vérification sélection haute
        if (GetTopClothes(selectedColumnIndex) == (clothes))
        {
            selectableClothes = true;
            //Debug.Log("MMMMM");
        }

        if (selectableClothes)
        {
            GameObject[] column = GetColumnFromIndex(indexColumn);
            int i = 3;
            if (column[4] == null)
            {
                for (; i >= 0; i--)
                {
                    if (column[i] != null)
                    {
                        if (column[i].GetComponent<Sweater>().size < clothes.GetComponent<Sweater>().size)
                        {
                            break;
                        }
                    }
                }
            }
            indexPossible = i + 1;
        }
        
        return indexPossible;
    }
    

    public static GameObject[] GetColumnFromIndex(int index)
    {
        GameObject[] column = null;

        switch (index)
        {
            case 0:
                column = Column0Clothes;
                break;
            case 1:
                column = Column1Clothes;
                break;
            case 2:
                column = Column2Clothes;
                break;
            case 3:
                column = Column3Clothes;
                break;
        }
        return column;
    }
    public static GameObject GetTopClothes(int indexColumn)
    {
        GameObject clothes = null;

        GameObject[] column = GetColumnFromIndex(indexColumn);


        if (column !=null)
        {
            for (int i = 4; i >= 0; i--)
            {
                if (column[i] != null)
                {
                    clothes = column[i];
                    break;
                }
            }
        }
        
        
        return clothes;
    }
}
