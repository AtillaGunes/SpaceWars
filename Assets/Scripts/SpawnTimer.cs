using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTimer : MonoBehaviour
{
    public GameObject spawner;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
   
    void Start()
    {
      InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    

    public void SpawnObject() {
        Instantiate(spawner, transform.position, transform.rotation);
        if(stopSpawning){
            CancelInvoke("SpawnObject");
        }
    }
}
