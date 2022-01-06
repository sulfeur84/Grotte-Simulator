using UnityEngine;
using UnityEngine.Tilemaps;

public class GenerationProcedural : MonoBehaviour
{
    public float Seed;
    public float XSize, YSize;
    public float Zoom;
    public float Seuil;
    public Tile With, Black;
    public Tilemap TileMap;
    
    public void Update()
    {
        TileMap.ClearAllTiles();
        for (int y = 0; y < YSize; y++) {
            for (int x = 0; x < XSize; x++) {
                float PerlinValue = Mathf.PerlinNoise (Seed + x * Zoom, Seed + y * Zoom);
                
                if(PerlinValue >= Seuil) TileMap.SetTile(new Vector3Int(x, y, 0), Black);
                else TileMap.SetTile(new Vector3Int(x, y, 0), With);
            }
        }
    }
}
