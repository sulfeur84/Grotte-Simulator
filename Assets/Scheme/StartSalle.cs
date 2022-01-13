using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class StartSalle : MonoBehaviour
{
    public GameObject Haut, Bas, Gauche, Droite;
    private int H, B, G, D;
    private Transform MyTransform;

    public static int DungeonsNbr;
    public int DungeonsMax;
    public void Awake()
    {
        Salles.DungeonsMax = DungeonsMax;
        MyTransform = GetComponent<Transform>();
        H = Random.Range(0, 5);
        B = Random.Range(0, 5);
        G = Random.Range(0, 5);
        D = Random.Range(0, 5);
    }

    public void Start()
    {
        if (H >= 1 && DungeonsNbr <= DungeonsMax)
        {
            Instantiate(Haut, new Vector3(MyTransform.position.x,MyTransform.position.y + 2),Quaternion.identity);
            DungeonsNbr++;
        }

        if (B >= 1 && DungeonsNbr <= DungeonsMax)
        {
            Instantiate(Bas, new Vector3(MyTransform.position.x,MyTransform.position.y - 2),Quaternion.identity);
            DungeonsNbr++;
        }

        if (G >= 1&& DungeonsNbr <= DungeonsMax)
        {
            Instantiate(Gauche, new Vector3(MyTransform.position.x - 3,MyTransform.position.y),Quaternion.identity);
            DungeonsNbr++;
        }

        if (D >= 1&& DungeonsNbr <= DungeonsMax)
        {
            Instantiate(Droite, new Vector3(MyTransform.position.x + 3,MyTransform.position.y),Quaternion.identity);
            DungeonsNbr++;
        }
    }
    
    
}
