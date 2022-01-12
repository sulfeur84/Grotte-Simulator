
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class JeuDlaVie : MonoBehaviour
{
    public int TabSize;
    public Tilemap TM;
    public Tile Black, Withe;

    public int[,] FirstTablo = new int[,]
    {
        {0,0,0,0},
        {0,1,1,1},
        {1,1,1,0},
        {0,0,0,0},
    };
    
    public int[,] SecondTablo = new int[,]
    {
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0},
    };

    public void Start()
    {
        for (int x = 0; x < TabSize; x++)
        {
            for (int y = 0; y < TabSize; y++)
            {
                if (FirstTablo[x, y] == 1)
                {
                    TM.SetTile(new Vector3Int(x, y, 0), Withe);
                }
                else
                {
                    TM.SetTile(new Vector3Int(x, y, 0), Black);
                }
            }
        }

        Debug.Log("\n" + FirstTablo[0, 0] + "" + FirstTablo[0, 1] + FirstTablo[0, 2] + FirstTablo[0, 3] +
                  "\n" + FirstTablo[1, 0] + "" + FirstTablo[1, 1] + FirstTablo[1, 2] + FirstTablo[1, 3] +
                  "\n" + FirstTablo[2, 0] + "" + FirstTablo[2, 1] + FirstTablo[2, 2] + FirstTablo[2, 3] +
                  "\n" + FirstTablo[3, 0] + "" + FirstTablo[3, 1] + FirstTablo[3, 2] + FirstTablo[3, 3]);

        }

    public void Update()
    {
        for (int x = 0; x < TabSize; x++){
            for (int y = 0; y < TabSize; y++)
            {
                SecondTablo[x,y] = AmIDed(AliveNeighborCount(x,y),x,y);
            }
        }
    }
    public int AliveNeighborCount(int x, int y)
    {
        int count = 0;
        if (GetCellStatus(x, y+1) > 0) count++;
        if (GetCellStatus( x+1, y+1) > 0) count++;
        if (GetCellStatus(x+1, y ) > 0) count++;
        if (GetCellStatus(x, y-1) > 0) count++;
        if (GetCellStatus(x-1, y-1) > 0) count++;
        if (GetCellStatus(x-1, y) > 0) count++;
        if (GetCellStatus(x-1, y+1) > 0) count++;
        if (GetCellStatus(x+1, y-1) > 0) count++;
        return count;
    }
    public int GetCellStatus(int x, int y) {
        if (x < 0 || x >= TabSize) return 0;
        if (y < 0 || y >= TabSize) return 0;
        return FirstTablo[x, y];
    }
    public int AmIDed(int count, int x, int y)
    {
        if (count < 2 || count > 3) return 0;
        else if (count == 3) return 1;
        else return FirstTablo[x, y];
    }
    public void Refresh()
    {
        FirstTablo = SecondTablo.Clone() as int[,];
        for (int x = 0; x < TabSize; x++){
            for (int y = 0; y < TabSize; y++)
            {
                if (FirstTablo[x,y] == 1)
                {
                    TM.SetTile(new Vector3Int(x,y,0),Withe);
                }
                else
                {
                    TM.SetTile(new Vector3Int(x,y,0),Black);
                }
            }
        }
        Debug.Log("\n"+ FirstTablo[0,0] +""+ FirstTablo[0,1] + FirstTablo[0,2] + FirstTablo[0,3] + 
                  "\n" + FirstTablo[1,0] +""+ FirstTablo[1,1] + FirstTablo[1,2] + FirstTablo[1,3] +
                  "\n" + FirstTablo[2,0] +""+ FirstTablo[2,1] + FirstTablo[2,2] + FirstTablo[2,3] +
                  "\n" + FirstTablo[3,0] +""+ FirstTablo[3,1] + FirstTablo[3,2] + FirstTablo[3,3]);
        SecondTablo = new int[4, 4];
    }
}
