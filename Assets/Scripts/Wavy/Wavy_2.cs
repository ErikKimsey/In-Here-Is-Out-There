using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wavy_2 : MonoBehaviour
{
    
    float perlinNoise = 0f;
    public float refinement = 0f;
    public float multiplier = 0f;
    public int rowsAndColumns = 0;
    public float[,] terrainHeightData;
    Terrain terrain;

    void Start()
    {
      terrain = GetComponent<Terrain>();

      terrainHeightData = new float[rowsAndColumns, rowsAndColumns];
      HandleRefinementValues();
    }

    public void CreateTerrain(){
      for(int i=0; i<rowsAndColumns; i++){
        for (int j = 0; j < rowsAndColumns; j++)
        {
          perlinNoise = Mathf.PerlinNoise(i * refinement, j * refinement);
          
          terrainHeightData[i,j] = perlinNoise * multiplier;
        }
      }
      terrain.terrainData.SetHeights(0,0, terrainHeightData);
    }

    private void HandleRefinementValues(){
      // refinement += Time.time;
      // multiplier = Random.Range(0.01f, 0.015f);
      refinement = Random.Range(0.01f, 0.012f);
      multiplier = Random.Range(0.01f, 0.015f);
      CreateTerrain();  
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      // HandleRefinementValues();
      CreateTerrain();  
    }
}
