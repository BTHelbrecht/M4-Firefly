using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMotor : MonoBehaviour
{
    Transform tankPosition;

    private void Awake()
    {
        tankPosition = this.gameObject.transform;
    }

    public void TankEngine(float speed)
    {
        tankPosition.transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
    }

    public void TankRotation(float speed)
    {
        tankPosition.transform.Rotate(new Vector3(0, 10, 0) * speed * Time.deltaTime);
    }
}
