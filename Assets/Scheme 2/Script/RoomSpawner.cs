using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class RoomSpawner : MonoBehaviour
{
    public int OpeningDirection;
    // 1 = Bas
    // 2 = Haut
    // 3 = Gauche
    // 4 = Droite

    private RommTemplate Template;
    private int Rand;
    private bool Spawned = false;
    public void Start()
    {
        Template = GameObject.FindGameObjectWithTag("Room").GetComponent<RommTemplate>();
        Invoke("Spawn",0.1f);
    }

    public void Spawn()
    {
        if (!Spawned)
        {
            if (OpeningDirection == 1)
            {
                Rand = Random.Range(0, Template.Haut.Length);
                Instantiate(Template.Haut[Rand], transform.position, Quaternion.identity);
            } else if (OpeningDirection == 2)
            {
                Rand = Random.Range(0, Template.Bas.Length);
                Instantiate(Template.Bas[Rand], transform.position, Quaternion.identity);
            } else if (OpeningDirection == 3)
            {
                Rand = Random.Range(0, Template.Droite.Length);
                Instantiate(Template.Droite[Rand], transform.position, Quaternion.identity);
            }else if (OpeningDirection == 4)
            {
                Rand = Random.Range(0, Template.Gauche.Length);
                Instantiate(Template.Gauche[Rand], transform.position, Quaternion.identity);
            }

            Spawned = true;
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SpawnPoint"))
        {
            Destroy(gameObject);
        }
    }
}
