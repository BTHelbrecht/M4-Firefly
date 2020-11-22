using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyTanks : MonoBehaviour
{
    public GameObject enemyTank;

    [Header("Spawn Point Array")]
    public GameObject[] spawnPoint;


    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemyTank()
    {
        for(int x = 0; x < spawnPoint.Length; x++ )
        {
            GameObject intanceEnemyTank = Instantiate(enemyTank, spawnPoint[x].transform.position, spawnPoint[x].transform.rotation) as GameObject;
        }
        
    }
}
