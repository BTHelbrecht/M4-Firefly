using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankControls : MonoBehaviour
{
    Transform tankPosition;

    public float speedForward;
    public float speedReverse;
    public float speedTankRotation;

    // Start is called before the first frame update
    void Start()
    {
        tankPosition = this.gameObject.transform;
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
            TankMotor(speedForward);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Reverse");
            TankMotor(-speedReverse);
        }
        else
        {
            Debug.Log("Idol Dirve");
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Left");
            TankRotation(speedTankRotation);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Right");
            TankRotation(-speedTankRotation);
        }
        else
        {
            Debug.Log("Idol Rotate");
        }
    }

    void TankMotor(float speed)
    {
        tankPosition.transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
    }

    void TankRotation(float speed)
    {
        tankPosition.transform.Rotate(new Vector3(0, 10, 0) * speed * Time.deltaTime);
    }
}
