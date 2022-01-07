using System;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class GenerationProcedural : MonoBehaviour
{
    public float Seed;
    public float XSize, YSize;
    public float Zoom;
    public float Seuil;
    public RuleTile Cave;
    public Tile Black;
    public Tilemap TileMap;

    public Slider sliderS, sliderZ;


    public void Update()
    {
        TileMap.ClearAllTiles();
        for (int y = 0; y < YSize; y++) {
            for (int x = 0; x < XSize; x++) {
                float PerlinValue = Mathf.PerlinNoise (Seed + x * Zoom, Seed + y * Zoom);
                
                if(PerlinValue <= Seuil) TileMap.SetTile(new Vector3Int(x, y, 0), Cave);
                //else TileMap.SetTile(new Vector3Int(x, y, 0), Cave);
            }
        }

        Seuil = sliderS.value;
        Zoom = sliderZ.value;


    }
    
}
