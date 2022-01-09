using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    public Image Img;
    public bool Here;

    public void Start()
    {
        Img = GetComponent<Image>();
    }

    public void Click()
    {
        if (!Here) Here = true;
        else Here = false;
        
        if(Here == true) Img.color = Color.black;
        else Img.color = Color.white;
    }
}
