using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopUpScript : MonoBehaviour
{
    public TextMeshProUGUI text;
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    


    public void SetPopUp(string message, PopUpManager.PopUpImage image)
    {
        //SetImage
        spriteRenderer.sprite = Resources.Load<Sprite>("Sprites/UI/" + image.ToString());
        text.text = message;
    }

    public void ClosePopUp()
    {
        Game.CloseMenu();
    }
}
