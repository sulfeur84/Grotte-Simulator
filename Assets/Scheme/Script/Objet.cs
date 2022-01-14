using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using Random = UnityEngine.Random;

public class Objet : MonoBehaviour
{
    public List<GameObject> Objects = new List<GameObject>();
    private Transform MyTrans;

    public float MinX, MaxX, MinY, MaxY;

    public void Awake()
    {
        MyTrans = GetComponent<Transform>();
    }

    public void Start()
    {
        Vector3 newRotation = new Vector3(0, 0, Random.Range(0, 360));
        int PrefabIndex = Random.Range(0,Objects.Count);
        Instantiate(Objects[PrefabIndex], new Vector3(MyTrans.position.x + Random.Range(MinX, MaxX), 
            MyTrans.position.y + Random.Range(MinY, MaxY)), Quaternion.Euler(0,0,Random.Range(0,360)));
    }
}
