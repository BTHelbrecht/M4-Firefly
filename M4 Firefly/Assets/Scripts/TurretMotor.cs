using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TANK TURRET MOTOR
public class TurretMotor : MonoBehaviour
{
    // Variable to hold turret object
    [Header ("Turret Object")]
    public GameObject tankTurret;

    // Tranform of turret object
    Transform turretPosition;

    // Use Before Start
    private void Awake()
    {
        // Assign Turret tranform as turrets tranform (LOCATION>ROTATION)
        turretPosition = tankTurret.gameObject.transform;
    }

    // Rotate Function... Take speed from tank data
    public void TurretRotation(float speed) 
    {
        // Turret turrt rotation is a noew value based on y axis with a multipler of time and speed.
        turretPosition.transform.Rotate(new Vector3(0, 10, 0) * speed * Time.deltaTime);
    }
}
