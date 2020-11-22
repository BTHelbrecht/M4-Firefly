using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellDamage : MonoBehaviour
{
    public GameObject enemyTank;
    Collider enemyTankCollider;
    private void Awake()
    {
        enemyTankCollider = enemyTank.gameObject.GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if (other == enemyTankCollider)
        {
            Debug.Log("Hit Tank");
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log("Hit Other");
            Destroy(this.gameObject);
        }
    }
}
