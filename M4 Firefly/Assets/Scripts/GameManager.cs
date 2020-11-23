using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;
using UnityEngine;

// GAME MANAGER SCRIPT
public class GameManager : MonoBehaviour
{
    // assign terrain game object to spawn
    public GameObject terrain;

    // use script to get array for enemy takes
    SpawnEnemyTanks enemiesArray;

    // Start is called before the first frame update
    void Start()
    {
        // call terrain to spawn
        MakeTerrain();
        // Call enemies to spawn
        MakeEnemies();
    }

    // Update is called once per frame
    void Update()
    {
       /*
        * game menu
        if (button start game)
        {
        Spawn enemy and player and switch to player cam
        }
        else if (button exit game)
        {
        leave app
        }
        else
        {
        debug
        }

        during menu game
        if (Button menu Game)
        {
        return to menu
        }
        else if ( Button Exit game)
        {
        Leave app
        }
        else
        {
        Debug
        }


         */ 
    }

    // instance of Terrain
    private void MakeTerrain()
    {
        GameObject.Instantiate(terrain, terrain.transform.position, terrain.transform.rotation);
    }

    // instance of enemy tanks in an array
    private void MakeEnemies()
    {
        // assign variable to enemy array
        // call the spawnenemy array
        enemiesArray = this.gameObject.GetComponent<SpawnEnemyTanks>();
        enemiesArray.SpawnEnemyTank();
    }

   
}
