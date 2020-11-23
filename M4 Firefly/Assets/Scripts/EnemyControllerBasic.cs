using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ENEMY CONTROLLER
public class EnemyControllerBasic : MonoBehaviour
{
    // Cooldown Variables
    public float coolDown;
    private float nextFireTime;

    // Update is called once per frame
    void Update()
    {
        // if the elapse time isn't equal to time needed to fire
        if (Time.time > nextFireTime)
        {
            //reset cooldown to fire shell
            nextFireTime = Time.time + coolDown;
            // shell not active for enemies using debug
            Debug.Log("Enemy Fire");
        }
    }
}
