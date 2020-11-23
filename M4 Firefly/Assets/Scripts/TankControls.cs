using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TANK CONTROLLER
public class TankControls : MonoBehaviour
{
    // assign game manger via inspector... weak singleton
    [Header ("GameManger Obj for Shells")]
    public GameObject managerObject;

    // variables for component and class access
    TankData tankData;
    TankMotor tankMotor;
    TurretMotor turretMotor;
    InstantiateShell shellInstance;

    // cooldown variable for ROF
    [Header("Shell Shoot Delay")]
    public float coolDownTime;
    private float nextFireTime = 0;

    //Use Before Start
    void Awake()
    {
        // Assign all components to variable on awake.
        tankData = this.gameObject.GetComponent<TankData>();
        tankMotor = this.gameObject.GetComponent<TankMotor>();
        turretMotor = this.gameObject.GetComponentInChildren<TurretMotor>();
        shellInstance = this.managerObject.gameObject.GetComponentInParent<InstantiateShell>();
    }

    // Update is called once per frame
    void Update()
    {
        // call input manager
        InputManager();
    }

    // input manager
    void InputManager()
    {
        // move tank
        //w is forward
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Tank Forward");
            // call drive fuction
            tankMotor.TankEngine(tankData.speedForward);
        }
        //s is backward
        else if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Tank Reverse");
            // call drive fuction with negative... reverse 
            tankMotor.TankEngine(-tankData.speedReverse);
        }
        //else idol
        else
        {
            Debug.Log("Idol Dirve");
        }


        // rotate tank
        //a is left tank turn
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Tank Left");
            //call tank rotation negative
            tankMotor.TankRotation(-tankData.speedTankRotation);
        }
        //d is right tank turn
        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Tank Right");
            //call tank rotation normal
            tankMotor.TankRotation(tankData.speedTankRotation);
        }
        //else rotaion idol
        else
        {
            Debug.Log("Idol Rotate");
        }

        // rotate turret
        //LA is turret left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Turret Left");
            //cal turret rotation negative
            turretMotor.TurretRotation(-tankData.speedTurretRotation);
        }
        //RA is turret right
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Turret Right");
            //call turret rotation normal
            turretMotor.TurretRotation(tankData.speedTurretRotation);
        }
        //else turret idol
        else
        {
            Debug.Log("Idol Turret");
        }

        // Shoot + Cooldown
        // if coodown time and time elapse are not greater
        if(Time.time > nextFireTime)
        {
            // if space was pressed down one activation
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // call fire shell
                // reset cooldowntime
                Debug.Log("Fired Shell");
                shellInstance.FireShell();
                nextFireTime = Time.time + coolDownTime;
            }
        }
    }
}
