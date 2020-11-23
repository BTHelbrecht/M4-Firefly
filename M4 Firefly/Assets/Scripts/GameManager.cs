using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject terrain;
    public GameObject player;
    public GameObject Camera;

    SpawnEnemyTanks enemiesArray;

    // Start is called before the first frame update
    void Start()
    {
        MakeTerrain();
        MakeEnemies();
        MakePlayer();
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

    private void MakeTerrain()
    {
        GameObject.Instantiate(terrain, terrain.transform.position, terrain.transform.rotation);
    }

    private void MakeEnemies()
    {
        enemiesArray = this.gameObject.GetComponent<SpawnEnemyTanks>();
        enemiesArray.SpawnEnemyTank();
    }

    private void MakePlayer()
    {
        GameObject.Instantiate(player, player.transform.position, player.transform.rotation);
    }

    private void MakeCamera()
    {
        GameObject.Instantiate(Camera, Camera.transform.position, Camera.transform.rotation);
    }
}
