using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TANK DATA VARIABLES
public class TankData : MonoBehaviour
{
    // Variables for tank via inspector
    [Header("Tank Data Variables")]
    public float speedForward;  // speed modifier    
    public float speedReverse;  //speed backwards modifier
    public float speedTankRotation; // tank rotation modifier
    public float speedTurretRotation;   // turret rotation modifier
    public float tankHealth;    // tank HP
    public int ammoCapacity;    // future feature ammo
}
