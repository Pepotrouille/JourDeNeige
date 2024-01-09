using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScale : MonoBehaviour
{
    public float currentScale;
    void Start()
    {
        float newScale = currentScale / GameObject.FindGameObjectWithTag("Canvas").transform.localScale.x;
        this.transform.localScale = new Vector3( newScale, newScale, 1);
    }

}
