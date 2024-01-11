using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PopUpScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Image dialoguePortraitImage;
    // public SpriteRenderer spriteRenderer; // 'spriteRenderer' field name was too vague. Changing it to 'dialoguePortraitImage'
    
    public void SetPopUp(string message, PopUpManager.PopUpImage image)
    {
        //SetImage
        dialoguePortraitImage.sprite = Resources.Load<Sprite>("Sprites/UI/" + image.ToString());
        text.text = message;
    }

    public void ClosePopUp()
    {
        Game.CloseMenu();
    }
}
