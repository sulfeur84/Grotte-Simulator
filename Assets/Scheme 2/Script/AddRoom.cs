using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRoom : MonoBehaviour
{
    private RommTemplate Templates;

    public void Start()
    {
        Templates = GameObject.FindGameObjectWithTag("Room").GetComponent<RommTemplate>();
        Templates.Rooms.Add(gameObject);
    }
}
