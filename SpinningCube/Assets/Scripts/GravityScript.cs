using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Gyroscope = UnityEngine.Gyroscope;


public class GravityScript : MonoBehaviour
{
    public static GravitySensor current { get; }
    // Start is called before the first frame update
    void Start()
    {
        InputSystem.EnableDevice(Gyroscope.current);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
