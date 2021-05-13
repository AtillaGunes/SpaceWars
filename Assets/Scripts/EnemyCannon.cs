using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCannon : MonoBehaviour
{
    
	public Transform m_muzzle;
	public GameObject m_shotPrefab;
    
    void Start()
    {
       
        InvokeRepeating("LaunchProjectile", 1, 0.5F);
    }

    void LaunchProjectile()
    {
       GameObject go = GameObject.Instantiate(m_shotPrefab, m_muzzle.position, m_muzzle.rotation) as GameObject;
			GameObject.Destroy(go, 5f);
    }
    void Update()
    {
        

              
           //   transform.position += transform.forward * Time.deltaTime * 170.0f;
              
              
    }
}
