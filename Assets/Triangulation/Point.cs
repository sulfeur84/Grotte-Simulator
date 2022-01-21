using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Point : MonoBehaviour
{
    private TriangulaSpawn Triangle;

    public void Start()
    {
        Triangle = GameObject.FindGameObjectWithTag("Speed").GetComponent<TriangulaSpawn>();
        Triangle.Salles.Add(gameObject);
    }
}
