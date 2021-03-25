using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                       transform.position -= transform.up * Time.deltaTime * 5.0f;

                        transform.position += transform.right * Time.deltaTime * 4.0f;

    }
}
