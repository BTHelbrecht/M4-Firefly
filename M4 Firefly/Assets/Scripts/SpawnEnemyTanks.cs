using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// SPAWN ENEMIES
public class SpawnEnemyTanks : MonoBehaviour
{
    // variable to be assigned as enemy via inspector
    [Header ("Enemy Tank Object")]
    public GameObject enemyTank;

    // variable to be assigned as enemy via inspector as array
    [Header("Spawn Point Array")]
    public GameObject[] spawnPoint;


    //Spawn enemys from array to game
    public void SpawnEnemyTank()
    {
        // for eany index make and instance of the enemy tank.
        for(int x = 0; x < spawnPoint.Length; x++ )
        {
            // make and nmy tank game object
            GameObject intanceEnemyTank = Instantiate(enemyTank, spawnPoint[x].transform.position, spawnPoint[x].transform.rotation) as GameObject;
        }
    }
}
