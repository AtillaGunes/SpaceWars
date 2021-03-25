using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       		transform.position += transform.forward * Time.deltaTime * 170.0f;
             transform.RotateAround(Vector3.zero, Vector3.forward, 20 * Time.deltaTime);
            
    }
}
