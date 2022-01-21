using System;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Random = UnityEngine.Random;

public class TriangulaSpawn : MonoBehaviour
{
    public GameObject Salle;
    public int MaxSalle;
    private Transform MyTrans;
    public float MinX, MaxX, MinY, MaxY;

    public List<GameObject> Salles;

    public void Awake()
    {
        MyTrans = GetComponent<Transform>();
    }
    void Start()
    {
        for (int i = 0; i < MaxSalle; i++)
        {
            Instantiate(Salle, new Vector3(MyTrans.position.x + Random.Range(MinX, MaxX), 
                MyTrans.position.y + Random.Range(MinY, MaxY)), Quaternion.identity);;
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene("Triangulation");    
    }
}
