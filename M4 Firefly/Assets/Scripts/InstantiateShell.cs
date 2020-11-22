using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateShell : MonoBehaviour
{
    [Header ("Shell and Turret Objects")]
    public GameObject shell;
    public GameObject turretFirePoint;

    Rigidbody shellBody;
    ShellData shellData;
    // Component destroyShell;
    

    private void Awake()
    {
        shellBody = shell.gameObject.GetComponent<Rigidbody>();
        shellData = shell.gameObject.GetComponent<ShellData>();
        // destroyShell = shell.gameObject.GetComponent<DelayedDestroy>();
    }

    public void FireShell()
    {
        Rigidbody shell = Instantiate(shellBody, turretFirePoint.transform.position, turretFirePoint.transform.rotation) as Rigidbody;

        shell.velocity = shellData.shellVelocity * turretFirePoint.transform.forward;
    }
}
