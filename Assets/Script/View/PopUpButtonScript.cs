using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopUpButtonScript : MonoBehaviour
{
    public TextMeshProUGUI text;
    public SpriteRenderer spriteRenderer;
    public TextMeshProUGUI cancelButtonText;
    public TextMeshProUGUI acceptButtonText;
    public GameObject acceptButton;

    AcceptMethod acceptMethod;

    // Start is called before the first frame update



    public void SetPopUp(string message, PopUpManager.PopUpImage image, string cancelButtonText, string acceptButtonText, AcceptMethod.TypeAcceptMethod type)
    {
        //SetImage
        spriteRenderer.sprite = Resources.Load<Sprite>("Sprites/UI/" + image.ToString());
        this.text.text = message;
        this.cancelButtonText.text = cancelButtonText;
        this.acceptButtonText.text = acceptButtonText;
        switch(type)
        {
            case AcceptMethod.TypeAcceptMethod.TAKESHOWER:
                acceptMethod = this.gameObject.AddComponent<TakeShowerAM>();
                break;
            case AcceptMethod.TypeAcceptMethod.OPENVENT:
                acceptMethod = this.gameObject.AddComponent<OpenVentAM>();
                break;
            case AcceptMethod.TypeAcceptMethod.TAKETOOLBOX:
                acceptMethod = this.gameObject.AddComponent<ToolBoxAM>();
                break;
            case AcceptMethod.TypeAcceptMethod.TAKESCARF:
                acceptMethod = this.gameObject.AddComponent<TakeScarfAM>();
                break;
            case AcceptMethod.TypeAcceptMethod.GOOUT:
                acceptMethod = this.gameObject.AddComponent<GoOutAM>();
                break;
            case AcceptMethod.TypeAcceptMethod.OPENCLOSET:
                acceptMethod = this.gameObject.AddComponent<OpenClosetAM>();
                break;
            case AcceptMethod.TypeAcceptMethod.TAKELEFTBOOT:
                acceptMethod = this.gameObject.AddComponent<TakeLeftBootAM>();
                break;
            case AcceptMethod.TypeAcceptMethod.TAKERIGHTBOOT:
                acceptMethod = this.gameObject.AddComponent<TakeRightBootAM>();
                break;
        }
        
    }

    public void ActionAccept()
    {
        acceptMethod.Accept();
    }

    public void ClosePopUp()
    {
        Game.CloseMenu();
    }
}
