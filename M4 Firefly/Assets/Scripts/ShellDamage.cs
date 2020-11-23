using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// SHELL SELFDESTRUCT
public class ShellDamage : MonoBehaviour
{
    // When a shel hit anything
    private void OnTriggerEnter(Collider other)
    {
        // Destroy the shell (THIS OBJ)
        Destroy(this.gameObject);
    }
}
