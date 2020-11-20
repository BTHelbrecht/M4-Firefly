using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankControls : MonoBehaviour
{
    //Transform tankPosition;
    TankData tankData;
    TankMotor tankMotor;

    //public float speedForward;
    //public float speedReverse;
    //public float speedTankRotation;

    // Start is called before the first frame update

    

    void Start()
    {
        //tankPosition = this.gameObject.transform;
        tankData = this.gameObject.GetComponent<TankData>();
        tankMotor = this.gameObject.GetComponent<TankMotor>();
    }

    // Update is called once per frame
    void Update()
    {
        InputManager();
    }


    void InputManager()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Forward");
            tankMotor.TankEngine(tankData.speedForward);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Reverse");
            tankMotor.TankEngine(-tankData.speedReverse);
        }
        else
        {
            Debug.Log("Idol Dirve");
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Left");
            tankMotor.TankRotation(-tankData.speedTankRotation);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Right");
            tankMotor.TankRotation(tankData.speedTankRotation);
        }
        else
        {
            Debug.Log("Idol Rotate");
        }


    }
/*
    void TankMotor(float speed)
    {
        tankData.transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
    }

    void TankRotation(float speed)
    {
        tankData.transform.Rotate(new Vector3(0, 10, 0) * speed * Time.deltaTime);
    }
*/
}
