using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public TankMotor tankMotor;

    // Start is called before the first frame update
    private void Awake()
    {
        tankMotor = gameObject.GetComponent<TankMotor>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveTank = Vector3.zero;
        Vector3 moveTurret = Vector3.zero;
        
        // move tank
        //w is forward
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Tank Forward");
            // call drive fuction
            moveTank.z = 1;
        }
        //s is backward
        else if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Tank Reverse");
            // call drive fuction with negative... reverse 
            moveTank.z = -1;
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
            moveTank.y = -1;
        }
        //d is right tank turn
        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Tank Right");
            //call tank rotation normal
            moveTank.y = 1;
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
            moveTurret.y = -1;
        }
        //RA is turret right
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Turret Right");
            //call turret rotation normal
            moveTurret.y = 1;
        }
        //else turret idol
        else
        {
            Debug.Log("Idol Turret");
        }

        tankMotor.TankEngine(moveTank);
        tankMotor.TurretEnigne(moveTurret);
    }
}
