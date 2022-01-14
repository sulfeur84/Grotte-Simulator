using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RommTemplate : MonoBehaviour
{
    public GameObject[] Bas;
    public GameObject[] Haut;
    public GameObject[] Gauche;
    public GameObject[] Droite;

    //public GameObject closedRoom;

    public List<GameObject> Rooms;

    public float WaitTime;
    private bool SpawnedBoss;
    public GameObject Boss;

    private void Update()
    {
        if (WaitTime <= 0 && !SpawnedBoss)
        {
            for (int i = 0; i < Rooms.Count; i++)
            {
                if (i == Rooms.Count - 1)
                {
                    Instantiate(Boss, Rooms[i].transform.position, Quaternion.identity);
                    SpawnedBoss = true;
                }
            }
        }
        else
        {
            WaitTime -= Time.deltaTime;
        }
    }
}
