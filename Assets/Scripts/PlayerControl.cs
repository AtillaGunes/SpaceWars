using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Quaternion originalRotationValue; // declare this as a Quaternion
    float rotationResetSpeed = 1.0f;
    void Start()
    {
        originalRotationValue = transform.rotation;  
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
                    transform.position += Vector3.left * Time.deltaTime * 130.0f;
                    transform.Rotate( 0, 0, 0.4f);
        }
        if(Input.GetKey(KeyCode.D)){
                    transform.position += Vector3.right * Time.deltaTime * 130.0f;
                    transform.Rotate( 0, 0, -0.4f);


        }
        if(Input.GetKey(KeyCode.W)){
                   transform.position += Vector3.up * Time.deltaTime * 130.0f;
                   transform.Rotate( -0.2f, 0, 0);
             

        }
        if(Input.GetKey(KeyCode.S)){
                    transform.position += Vector3.down * Time.deltaTime * 130.0f;
                     transform.Rotate( 0.2f, 0, 0);


        }
        else {
                transform.rotation = Quaternion.Slerp(transform.rotation, originalRotationValue, Time.deltaTime * rotationResetSpeed); 
        }

        
        transform.position += transform.forward * Time.deltaTime * 170.0f;
    }
}
