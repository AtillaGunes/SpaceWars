using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyroscope : MonoBehaviour
{
   public float smooth = 0.2f;  
    public float newRotation;
    public float sensitivity = 6;
    private Vector3 currentAcceleration, initialAcceleration;

    void Start()
    {
        Input.gyro.enabled = true;
        initialAcceleration = Input.acceleration;
        currentAcceleration = Vector3.zero;
    }
    
    void Update () {
         transform.eulerAngles = new Vector3(transform.eulerAngles.x - Input.gyro.rotationRateUnbiased.x * Time.deltaTime * Mathf.Rad2Deg , 0.0f, transform.eulerAngles.z + Input.gyro.rotationRateUnbiased.z * Time.deltaTime * Mathf.Rad2Deg);
         currentAcceleration = Vector3.Lerp(currentAcceleration, Input.acceleration - initialAcceleration, Time.deltaTime/smooth);
         transform.Translate(currentAcceleration.x, -currentAcceleration.y, 0);
    }
}
