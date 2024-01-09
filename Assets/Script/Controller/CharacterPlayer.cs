using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPlayer : MonoBehaviour
{

    //----------------ATTRIBUTES------------------


    readonly float walkSpeed = 0.07f;

    public static GameObject BootsGO;
    public static GameObject HatGO;
    public static GameObject ScarfGO;
    public static GameObject SweaterGO;

    public Animator theAnimator;
    public Animator BootsAnimator;
    public Animator ScarfAnimator;
    public Animator SweaterAnimator;
    public Animator HatAnimator;

    public SpriteRenderer theSpriteRenderer;
    public SpriteRenderer BootsSpriteRenderer;
    public SpriteRenderer ScarfSpriteRenderer;
    public SpriteRenderer SweaterSpriteRenderer;
    public SpriteRenderer HatSpriteRenderer;

    public BoxCollider2D theColliderBox;
    List<Collider2D> otherColliderBoxes;

    bool isIDLE;


    //-----------------------------------------


    //----------------METHODS------------------

    //----------------RUNTIME----------

    // Start is called before the first frame update
    void Awake()
    {

        theAnimator = this.GetComponent<Animator>();
        theSpriteRenderer = this.GetComponent<SpriteRenderer>();
        Game.Restart();
    }

    void Start()
    {
        BackToIDLEAnimation();
        theColliderBox = this.GetComponent<BoxCollider2D>();
        otherColliderBoxes = new List<Collider2D>();

        //--------------Set up Game Objects
        BootsGO = this.transform.GetChild(0).gameObject;
        BootsGO.SetActive(false);
        HatGO = this.transform.GetChild(1).gameObject;
        HatGO.SetActive(false);
        ScarfGO = this.transform.GetChild(2).gameObject;
        ScarfGO.SetActive(false);
        SweaterGO = this.transform.GetChild(3).gameObject;
        SweaterGO.SetActive(false);

        //--------------Set up Game Animators
        BootsAnimator = BootsGO.GetComponent<Animator>();
        HatAnimator = HatGO.GetComponent<Animator>();
        ScarfAnimator = ScarfGO.GetComponent<Animator>();
        SweaterAnimator = SweaterGO.GetComponent<Animator>();

        //--------------Set up Game Sprite Renderer
        BootsSpriteRenderer = BootsGO.GetComponent<SpriteRenderer>();
        HatSpriteRenderer = HatGO.GetComponent<SpriteRenderer>();
        ScarfSpriteRenderer = ScarfGO.GetComponent<SpriteRenderer>();
        SweaterSpriteRenderer = SweaterGO.GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (!Game.hasStarted)
        {
            PopUpManager.PopUpMessage("Woah il a neigé dehors !!! Il faut vite que je me prépare pour sortir ! Mais mes affaires sont un peu en désordre...", PopUpManager.PopUpImage.KIMISURPRISED);
            Game.hasStarted = true;
        }
            
        if (!Game.inMenu)
        {

            Vector3 new_pos = transform.position;


            if (Input.GetButton("Right"))
            {
                new_pos.x += walkSpeed;
                transform.position = new_pos;
                WalkRightAnimation();
            }
            else if (Input.GetButton("Left"))
            {
                new_pos.x -= walkSpeed;
                transform.position = new_pos;
                WalkLeftAnimation();
            }
            else if (!isIDLE)
            {
                BackToIDLEAnimation();
            }


            //-----------------------Interaction with other colliders---------------------------

            theColliderBox.OverlapCollider(new ContactFilter2D().NoFilter(), otherColliderBoxes);
            foreach (Collider2D otherBox in otherColliderBoxes)
            {
                GoToBox goToBoxScript;
                if ((goToBoxScript = otherBox.gameObject.GetComponent<GoToBox>()) != null)
                {
                    RoomManager.GoTo(goToBoxScript.placeToGo);
                }
            }


        }

    }


    //----------------AUTRES----------

    public void WalkRightAnimation()
    {
        theAnimator.Play("WALK");
        if(Game.hasBoots)
        {
            BootsAnimator.Play("BOOTS_WALK");
            BootsSpriteRenderer.flipX = false;
        }
        if (Game.hasScarf)
        {
            ScarfAnimator.Play("SCARF_WALK");
            ScarfSpriteRenderer.flipX = false;
        }
        if (Game.hasSweater)
        {
            SweaterAnimator.Play("SWEATER_WALK");
            SweaterSpriteRenderer.flipX = false;
        }
        if (Game.hasHat)
        {
            HatAnimator.Play("HAT_WALK");
            HatSpriteRenderer.flipX = false;
        }
        theSpriteRenderer.flipX = false;
        isIDLE = false;
    }
    public void WalkLeftAnimation()
    {
        theAnimator.Play("WALK");
        if (Game.hasBoots)
        {
            BootsAnimator.Play("BOOTS_WALK");
            BootsSpriteRenderer.flipX = true;
        }
        if (Game.hasScarf)
        {
            ScarfAnimator.Play("SCARF_WALK");
            ScarfSpriteRenderer.flipX = true;
        }
        if (Game.hasSweater)
        {
            SweaterAnimator.Play("SWEATER_WALK");
            SweaterSpriteRenderer.flipX = true;
        }
        if (Game.hasHat)
        {
            HatAnimator.Play("HAT_WALK");
            HatSpriteRenderer.flipX = true;
        }
        theSpriteRenderer.flipX = true;
        isIDLE = false;
    }

    public void BackToIDLEAnimation()
    {
        theAnimator.Play("IDLE");
        if (Game.hasBoots)
        {
            BootsAnimator.Play("BOOTS_IDLE");
        }
        if (Game.hasScarf)
        {
            ScarfAnimator.Play("SCARF_IDLE");
        }
        if (Game.hasSweater)
        {
            SweaterAnimator.Play("SWEATER_IDLE");
        }
        if (Game.hasHat)
        {
            HatAnimator.Play("HAT_IDLE");
        }
        isIDLE = true;
    }

    public static void ShowHat()
    {
        HatGO.SetActive(true);
    }
    public static void ShowBoots()
    {
        BootsGO.SetActive(true);
    }
    public static void ShowSweater()
    {
        SweaterGO.SetActive(true);
    }
    public static void ShowScarf()
    {
        ScarfGO.SetActive(true);
    }
    //--------------------------------
    //-----------------------------------------

}
