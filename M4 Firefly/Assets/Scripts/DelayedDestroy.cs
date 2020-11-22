using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedDestroy : MonoBehaviour
{
    [Header ("Desired Object to Destroy")]
    public GameObject gameObject;

    [Header ("Delay Time for Destroy")]
    public float delayTime;

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, delayTime);
    }
}
