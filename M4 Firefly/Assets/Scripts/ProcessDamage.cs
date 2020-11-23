using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessDamage : MonoBehaviour
{
    public GameObject enemytank;
    TankData tankData;

    private void Awake()
    {
        tankData = enemytank.gameObject.GetComponent<TankData>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Standard Shell")
        {
            this.tankData.tankHealth--;
        }

        if (this.tankData.tankHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
