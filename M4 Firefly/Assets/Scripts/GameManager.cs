using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header ("Spawn Point Array")]
    public GameObject[]spawnPoint;

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
        
    }
}
