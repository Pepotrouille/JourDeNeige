using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    //----------------ATTRIBUTES------------------




    public static bool inMenu;
    public static GameObject currentMenu;
    public static bool inSweaterGame;


    //Progress Game
    public static bool showerTaken;
    public static bool hasToolBox;
    public static bool hasHat;
    public static bool hasStarted;

    public static bool catAfraid;
    public static bool hasScarf;


    public static bool hasLeftBoot;
    public static bool hasRightBoot;
    public static bool hasBoots;


    public static bool hasSweater;



    //-----------------------------------------
    //----------------METHODS------------------
    //----------------RUNTIME----------




    //----------------AUTRES----------
    public static void SetMenu(GameObject newMenu)
    {
        currentMenu = newMenu;
        inMenu = true;
    }

    public static void CloseMenu()
    {
        if(currentMenu != null)
        {
            GameObject.Destroy(currentMenu);
        }
        inMenu = false;
    }

    public static void Restart()
    {
        CloseMenu();
        inSweaterGame = false;

        showerTaken = false;
        hasToolBox = false;
        hasHat = false;
        hasStarted = false;

        catAfraid = false;
        hasScarf = false;

        hasLeftBoot = false;
        hasRightBoot = false;
        hasBoots = false;

        hasSweater = false;
        Painting.finalOrientations = 0;
}
    public static void OpenSweaterGame()
    {
        inSweaterGame = true;
        RoomManager.GoToSweaterGame();
        inMenu = true;
    }

    public static void CloseSweaterGame()
    {
        inSweaterGame = false;
        RoomManager.QuitSweaterGame();
        inMenu = false;
    }

    //--------------------------------
    //-----------------------------------------
}
