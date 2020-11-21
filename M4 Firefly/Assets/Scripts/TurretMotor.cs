using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMotor : MonoBehaviour
{
    Transform turretPosition;
    private void Awake()
    {
        turretPosition = this.gameObject.transform;
    }

    public void TurretRotation(float speed) 
    {
        turretPosition.transform.Rotate(new Vector3(0, 10, 0) * speed * Time.deltaTime);
    }

}
