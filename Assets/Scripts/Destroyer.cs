using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
 
{
 public float LifeTİme = 5.0f;
    public void Update(){
        if(LifeTİme > 0) {
            LifeTİme -= Time.deltaTime;
            if (LifeTİme <= 0) {
                Destroy(this.gameObject);
            }
        }
    }
}
