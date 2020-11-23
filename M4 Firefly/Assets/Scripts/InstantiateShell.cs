using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MAKE A SHELL
public class InstantiateShell : MonoBehaviour
{
    // Variable for shell position and body to be assign in inspector
    [Header ("Shell and Turret Objects")]
    public GameObject shell;
    public GameObject turretFirePoint;

    // variable for shell data and body
    Rigidbody shellBody;
    ShellData shellData;

    // Use Before Start
    private void Awake()
    {
        // shelbody is shells rigidbody component
        // shelldata is shells sheldata component
        shellBody = shell.gameObject.GetComponent<Rigidbody>();
        shellData = shell.gameObject.GetComponent<ShellData>();
    }

    // Fire Shell
    public void FireShell()
    {
        //Shells rigidbody is a new instance of shell with the posistion of the turret.
        Rigidbody shell = Instantiate(shellBody, turretFirePoint.transform.position, turretFirePoint.transform.rotation) as Rigidbody;
        //the new instance is shot using velocity of rigidbody and multipler and time.
        shell.velocity = shellData.shellVelocity * turretFirePoint.transform.forward;
    }
}
