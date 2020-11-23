using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// TANK DAMAGE PROCCESS
public class ProcessDamage : MonoBehaviour
{
    // assign tank object via the inspector for enemies
    [Header ("Enamy Tank Object")]
    public GameObject enemytank;

    // assign tank data variable
    TankData tankData;

    // Use Before Start
    private void Awake()
    {
        // tankdata is the data from each enemy tank component
        tankData = enemytank.gameObject.GetComponent<TankData>();
    }

    // On Collider Tigger... When shell hits me...
    private void OnTriggerEnter(Collider other)
    {
        // if a standard shell
        if (other.tag == "Standard Shell")
        {
            // minus 1 health
            this.tankData.tankHealth--;
        }

        // if health is below starting health
        if (this.tankData.tankHealth <= 0)
        {
            // destroy this tank
            Destroy(this.gameObject);
        }
    }
}
