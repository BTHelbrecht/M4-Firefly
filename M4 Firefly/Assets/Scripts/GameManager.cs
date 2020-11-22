using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    SpawnEnemyTanks arraytest;

    // Start is called before the first frame update
    void Start()
    {
        arraytest = this.gameObject.GetComponent<SpawnEnemyTanks>();
        arraytest.SpawnEnemyTank();
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
}
