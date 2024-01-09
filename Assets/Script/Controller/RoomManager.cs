using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public enum Place { BALCONY, BEDROOMLEFT, BEDROOMRIGHT, LIVINGROOMLEFT, LIVINGROOMRIGHT, BATHROOM }
    static private readonly float[] characterPositions = {-31.4f, -22.2f, -13.3f, -4.2f, 4.2f, 15f};

    static private readonly float[] mainScenePositions = { 1320f, 660f, 0f, -660f };


    private static bool inMove;
    //private readonly float indent = 4f;
    //private readonly float indentMax = 85f;

    private static GameObject character;
    private static float characterNewPos;
    private static GameObject mainScene;
    private static float mainSceneNewPos;
    private static float mainSceneNewPosY;

    public static GameObject bathroom;
    public static GameObject bedroom;
    public static GameObject livingroom;
    public static GameObject balcony;
    public static GameObject closetGame;

    private static GameObject currentRoom;


    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.FindGameObjectWithTag("Player");
        mainScene = GameObject.FindGameObjectWithTag("MainScene");
        bathroom = GameObject.FindGameObjectWithTag("Bathroom");
        bathroom.SetActive(false);
        bedroom = GameObject.FindGameObjectWithTag("Bedroom");
        bedroom.SetActive(true);
        currentRoom = bedroom;
        livingroom = GameObject.FindGameObjectWithTag("Livingroom");
        livingroom.SetActive(false);
        balcony = GameObject.FindGameObjectWithTag("Balcony");
        balcony.SetActive(false);
        closetGame = GameObject.FindGameObjectWithTag("ClosetGame");
        closetGame.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(inMove)
        {
            Vector3 newPos = character.transform.localPosition;
            newPos.x = characterNewPos;
            character.transform.localPosition = newPos;

            newPos = mainScene.transform.localPosition;
            newPos.x = mainSceneNewPos;
            newPos.y = mainSceneNewPosY;
            mainScene.transform.localPosition = newPos;

            inMove = false;
        }
    }

    public static void GoTo(Place place)
    {
        inMove = true;
        characterNewPos = characterPositions[(int)(place)];
        mainSceneNewPosY = 0;
        currentRoom.SetActive(false);
        switch (place)
        {
            case Place.BALCONY:
                mainSceneNewPos = mainScenePositions[0];
                currentRoom = balcony;
                break;
            case Place.BEDROOMLEFT: case Place.BEDROOMRIGHT:
                mainSceneNewPos = mainScenePositions[1];
                currentRoom = bedroom;
                break;
            case Place.LIVINGROOMLEFT: case Place.LIVINGROOMRIGHT:
                mainSceneNewPos = mainScenePositions[2];
                currentRoom = livingroom;
                break;
            case Place.BATHROOM:
                mainSceneNewPos = mainScenePositions[3];
                currentRoom = bathroom;
                break;
        }
        currentRoom.SetActive(true);
    }//-478
    public static void GoToSweaterGame()
    {
        mainSceneNewPosY = -478;
        mainSceneNewPos = mainScenePositions[1];
        inMove = true;
    }
    public static void QuitSweaterGame()
    {
        GoTo(Place.BEDROOMRIGHT);
        inMove = true;
    }
}
