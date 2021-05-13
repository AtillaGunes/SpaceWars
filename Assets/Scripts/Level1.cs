using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level1 : MonoBehaviour
{
    void Start()
    {
        
    }

    
    void Update()
    {
        print(GameObject.FindGameObjectsWithTag("enemy").Length);

if(GameObject.FindGameObjectsWithTag("enemy").Length==0) { SceneManager.LoadScene("Level1"); }
    }
}
