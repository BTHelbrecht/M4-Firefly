using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMotor : MonoBehaviour
{
    public GameObject turretObject;

    public TankData tankData;
    public CharacterController simpleMove;

    void Awake()
    {
        tankData = GetComponent<TankData>();
        simpleMove = GetComponent<CharacterController>();
    }

    public void TankEngine(Vector3 moveOnAxis)
    {
        transform.Rotate(0, moveOnAxis.y * tankData.tankRotationModifier * Time.deltaTime, 0);
        Debug.Log(tankData.tankRotationModifier);
        Vector3 currentMoveVector = Vector3.zero;
        currentMoveVector.z = moveOnAxis.z * tankData.reverseSpeedModifier;
        currentMoveVector = transform.TransformDirection(currentMoveVector);
        simpleMove.SimpleMove(currentMoveVector);
    }

    public void TurretEnigne(Vector3 moveOnAxis)
    {
        turretObject.transform.Rotate(0, moveOnAxis.y * tankData.turretRotationModifier * Time.deltaTime, 0);
    }



}
