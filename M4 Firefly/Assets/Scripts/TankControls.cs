using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankControls : MonoBehaviour
{
    //Transform tankPosition;
    TankData tankData;
    TankMotor tankMotor;
    TurretMotor turretMotor;
    InstantiateShell shellInstance;

    void Awake()
    {
        //tankPosition = this.gameObject.transform;
        tankData = this.gameObject.GetComponent<TankData>();
        tankMotor = this.gameObject.GetComponent<TankMotor>();
        turretMotor = this.gameObject.GetComponentInChildren<TurretMotor>();
        shellInstance = gameObject.GetComponentInParent<InstantiateShell>();
    }

    // Update is called once per frame
    void Update()
    {
        InputManager();
    }


    void InputManager()
    {
        // move tank
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Tank Forward");
            tankMotor.TankEngine(tankData.speedForward);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Tank Reverse");
            tankMotor.TankEngine(-tankData.speedReverse);
        }
        else
        {
            Debug.Log("Idol Dirve");
        }


        // rotate tank
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Tank Left");
            tankMotor.TankRotation(-tankData.speedTankRotation);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Tank Right");
            tankMotor.TankRotation(tankData.speedTankRotation);
        }
        else
        {
            Debug.Log("Idol Rotate");
        }

        // rotate turret
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Turret Left");
            turretMotor.TurretRotation(-tankData.speedTurretRotation);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Turret Right");
            turretMotor.TurretRotation(tankData.speedTurretRotation);
        }
        else
        {
            Debug.Log("Idol Turret");
        }

        // Shoot
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Fired Shell");
            shellInstance.FireShell();
        }
    }
}
