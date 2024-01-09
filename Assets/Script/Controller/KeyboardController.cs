using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : MonoBehaviour
{
    void OnGUI()
    {
        Event e = Event.current;
        if (e.isKey)
        {
            if(e.keyCode.Equals(KeyCode.Escape))
            {
                if(Game.inSweaterGame)
                {
                    Game.CloseSweaterGame();
                }
                else
                {
                    Game.CloseMenu();
                }
               
            }
        }
    }
}
