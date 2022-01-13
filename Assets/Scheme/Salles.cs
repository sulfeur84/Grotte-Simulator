using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Salles : MonoBehaviour
{
    public GameObject Haut, Bas, Gauche, Droite;
    private int H, B, G, D;
    private Transform MyTransform;

    public bool IsH, IsB, IsG, IsD;
    
    public static int DungeonsMax;
    public void Awake()
    {
        MyTransform = GetComponent<Transform>();
        H = Random.Range(0, 2);
        B = Random.Range(0, 2);
        G = Random.Range(0, 2);
        D = Random.Range(0, 2);

        if (gameObject.CompareTag("Haut")) IsH = true;
        if (gameObject.CompareTag("Bas")) IsB = true;
        if (gameObject.CompareTag("Gauche")) IsG = true;
        if (gameObject.CompareTag("Droite")) IsD = true;
    }

    public void Start()
    {
        if (H == 1 && StartSalle.DungeonsNbr <= DungeonsMax && !IsB)
        {
            Instantiate(Haut, new Vector3(MyTransform.position.x,MyTransform.position.y + 2),Quaternion.identity);
            StartSalle.DungeonsNbr++;
        }

        if (B == 1 && StartSalle.DungeonsNbr <= DungeonsMax && !IsH)
        {
            Instantiate(Bas, new Vector3(MyTransform.position.x,MyTransform.position.y - 2),Quaternion.identity);
            StartSalle.DungeonsNbr++;
        }

        if (G == 1&& StartSalle.DungeonsNbr <= DungeonsMax && !IsD)
        {
            Instantiate(Gauche, new Vector3(MyTransform.position.x - 3,MyTransform.position.y),Quaternion.identity);
            StartSalle.DungeonsNbr++;
        }

        if (D == 1&& StartSalle.DungeonsNbr <= DungeonsMax && !IsG)
        {
            Instantiate(Droite, new Vector3(MyTransform.position.x + 3,MyTransform.position.y),Quaternion.identity);
            StartSalle.DungeonsNbr++;
        }
    }
    
    
}
