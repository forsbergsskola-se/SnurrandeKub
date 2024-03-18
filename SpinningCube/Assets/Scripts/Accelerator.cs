using UnityEngine;

public class GyroController : MonoBehaviour
{
    private Gyroscope gyro;

    void Start()
    {
        gyro.enabled = true;
        gyro = Input.gyro;
    }

    void Update()
    {
        // Apply gyro rotation to the GameObject this script is attached to
        transform.rotation = gyro.attitude;
    }
}