using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour
{
    public float localDelta;
    public float speed;

    private float limitMin;
    private float limitMax;

    private bool goingUp;
    // Start is called before the first frame update
    void Start()
    {
        limitMin = this.transform.localPosition.y - localDelta*0.5f;
        limitMax = this.transform.localPosition.y + localDelta * 0.5f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 newPos = this.transform.localPosition;
        if (goingUp)
        {
            newPos.y += speed;
            if (newPos.y> limitMax)
            {
                goingUp = false;
            }
        }
        else
        {
            newPos.y -= speed;
            if (newPos.y < limitMin)
            {
                goingUp = true;
            }
        }
        this.transform.localPosition = newPos;
    }
}
