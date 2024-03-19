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
        var gravity = GravitySensor.current.gravity.value;
        gravity.z *= -1; //Flip z axi since flat place phone yields negative z gravity
        gravity *= 9.81f; //scale gravity since sensor returns normalized values
        Physics.gravity = gravity;
    }
}