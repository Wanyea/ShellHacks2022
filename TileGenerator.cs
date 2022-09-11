using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    public GameObject tileT;
    public int size = 10;
    private int tileWidth, tileDepth;
    private Vector3 tileSize;
    // Mesh mesh;

    // Vector3[] vertices;
    // int[] triangles;

    // public int xSize = 1;
    // public int zSize = 1;

    // Start is called before the first frame update
    void Start()
    {
        tileSize = tileT.GetComponent<MeshRenderer>().bounds.size;
        tileWidth = (int)tileSize.x;
        // xSize = tileWidth; 
        tileDepth = (int)tileSize.z;
        // zSize = tileDepth;
        Vector3 pos = new Vector3(0-(size*tileWidth/2), 0, 0-(size*tileDepth/2));
        for (int i=0; i<size; i++){
            for (int j=0; j<size; j++){
                Instantiate(tileT, pos, Quaternion.identity);
                // mesh gen
                // mesh = new Mesh();
                // tileT.GetComponent<MeshFilter>().mesh = mesh;
                // CreateShape();
                // UpdateMesh();
                pos.x += tileWidth; 

            }
            pos.x = 0-(size*tileWidth/2); 
            pos.z += tileDepth; 
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //     void CreateShape()
    // {
    //     vertices = new Vector3[(xSize + 1) * (zSize + 1)];

    //     for (int i = 0, z =0; z<= zSize; z++)
    //     {
    //         for (int x = 0; x<=xSize; x++)
    //         {
    //             float y = Mathf.PerlinNoise(x * .3f, z * .3f) * 2f;
    //             vertices[i] = new Vector3(x, y, z);
    //             i++;
    //         }
    //     }

    //     triangles = new int[xSize * zSize * 6];

    //     int vert = 0;
    //     int tris = 0;

    //     for (int z = 0; z < zSize; z++)
    //     {
    //         for (int x = 0; x < xSize; x++)
    //         {
    //             triangles[tris + 0] = vert + 0;
    //             triangles[tris + 1] = vert + xSize + 1;
    //             triangles[tris + 2] = vert + 1;
    //             triangles[tris + 3] = vert + 1;
    //             triangles[tris + 4] = vert + xSize + 1;
    //             triangles[tris + 5] = vert + xSize + 2;

    //             vert++;
    //             tris += 6;
    //         }
    //         vert++;
    //     }

    // }

    // void UpdateMesh()
    // {
    //     mesh.Clear();
    //     mesh.vertices = vertices;
    //     mesh.triangles = triangles;
    //     mesh.RecalculateNormals();
    //     // optionally, add a mesh collider (As suggested by Franku Kek via Youtube comments).
    //     // To use this, your MeshGenerator GameObject needs to have a mesh collider
    //     // component added to it.  Then, just re-enable the code below.
        
    //     // mesh.RecalculateBounds();
    //     // MeshCollider meshCollider = tileT.GetComponent<MeshCollider>();
    //     // meshCollider.sharedMesh = mesh;
    
    // }
}
