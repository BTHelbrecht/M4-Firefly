using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMotor : MonoBehaviour
{
    public GameObject tankTurret;

    Transform turretPosition;
    private void Awake()
    {
        turretPosition = tankTurret.gameObject.transform;
    }

    public void TurretRotation(float speed) 
    {
        turretPosition.transform.Rotate(new Vector3(0, 10, 0) * speed * Time.deltaTime);
    }

}
