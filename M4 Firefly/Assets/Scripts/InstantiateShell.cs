using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateShell : MonoBehaviour
{
    public GameObject shell;
    public GameObject turretFirePoint;
    Rigidbody shellBody;
    

    private void Awake()
    {
        shellBody = shell.gameObject.GetComponent<Rigidbody>();
    }

    public void FireShell()
    {
        Rigidbody shell = Instantiate(shellBody, turretFirePoint.transform.position, turretFirePoint.transform.rotation) as Rigidbody;

        shell.velocity = 30 * turretFirePoint.transform.forward;
    }
}
