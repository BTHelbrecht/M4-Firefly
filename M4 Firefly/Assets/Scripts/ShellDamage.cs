using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellDamage : MonoBehaviour
{
    public GameObject enemyTank;
    Collider enemyTankCollider;
   
    private void Awake()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        enemyTankCollider = enemyTank.GetComponent<Collider>();

        Debug.Log(enemyTankCollider);
        Debug.Log(other);
        
        if (enemyTankCollider != other)
        {
            Debug.Log(other);
            Debug.Log("Hit Tank");
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
       
       

        /*dd
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
        }*/
    }
}
