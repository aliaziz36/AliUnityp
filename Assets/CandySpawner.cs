using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CandySpawner : MonoBehaviour
{
    public GameObject candy1P;     
    public GameObject candy2P;
    public GameObject candy3P; 
    public GameObject PumpkinP; 
    public GameObject GhostP;
    public int candy1_num = 25;         
    public int candy2_num = 10;
    public int candy3_num = 5;  
    public int pumpkin_num = 10; 
    public int ghost_num = 2; 
    public Vector2 min = new Vector2(8, -8);        
    public Vector2 max = new Vector2(200, 8);          
    void Start()
    {
        for (int i = 0; i <candy1_num; i++)
        {
            SpawnCandy(candy1P);
        }    
        for (int i = 0; i< candy2_num; i++)
        {
            SpawnCandy(candy2P);
        }
        for (int i = 0; i <candy3_num; i++)
        {
            SpawnCandy(candy3P);
        }
        for (int i = 0; i < pumpkin_num; i++)
        {
            SpawnCandy(PumpkinP);
        }
        for (int i = 0;i <ghost_num; i++)
        {
        SpawnCandy(GhostP);
        }
    }
    void SpawnCandy(GameObject candy)
    {
        Vector2 randomm =new Vector2(
            Random.Range(min.x, max.x),
            Random.Range(min.y, max.y)
        );
        Instantiate(candy, randomm, Quaternion.identity);
    }
}
