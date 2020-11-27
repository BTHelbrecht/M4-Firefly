using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TANK DATA VARIABLES
public class TankData : MonoBehaviour
{
    public GameObject turretObject;
    public GameObject firePointObject;

    // Variables for tank via inspector
    [Header("Tank Movement Data")]
    public float driveSpeedModifier;  // speed modifier    
    public float reverseSpeedModifier;  //speed backwards modifier
    public float tankRotationModifier; // tank rotation modifier
    public float turretRotationModifier;   // turret rotation modifier

    [Header("Tank Shooting Data")]
    public int tankAmmoCapacity;    // future feature ammo
    public float tankFireRate;

    [Header("Tank Status Data")]
    public float tankHealthPoints;    // tank HP
}
