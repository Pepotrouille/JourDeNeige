using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TakeShowerAM : AcceptMethod
{
    
    public override void Accept()
    {
        Game.showerTaken = true;
        Sprite[] allSprites = Resources.LoadAll<Sprite>("Sprites/Objects/Object_Bathroom");
        GameObject.FindGameObjectWithTag("Shower").GetComponent<SpriteRenderer>().sprite = allSprites.Single(s => s.name == "Shower_Wet");
        GameObject.FindGameObjectWithTag("Mirror").GetComponent<SpriteRenderer>().sprite = allSprites.Single(s => s.name == "Mirror_Foggy");
        GameObject.FindGameObjectWithTag("Fog").GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.3f);
        Game.CloseMenu();
    }
}
