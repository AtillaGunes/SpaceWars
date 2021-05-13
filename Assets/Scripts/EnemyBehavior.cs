using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public Transform target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       	//	transform.position -= transform.forward * Time.deltaTime * 2.0f;
             transform.RotateAround(Vector3.zero, Vector3.forward, 20 * Time.deltaTime);
             StartCoroutine(Look());
             
    }

    public IEnumerator Look()
    {
      yield return new WaitForSeconds(0.1f);
      transform.LookAt(target);
    }
}
