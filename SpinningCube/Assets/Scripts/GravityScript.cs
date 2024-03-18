using UnityEngine;
using UnityEngine.InputSystem;

public class GravityScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InputSystem.EnableDevice(GravitySensor.current);
    }
    
    void Update()
    {
        var gravity = GravitySensor.current.gravity;
        Physics.gravity = gravity.value;
    }
}