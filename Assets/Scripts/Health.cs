﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 100;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(curHealth <= 0){
            SceneManager.LoadScene("Level1");
        }

        
    }

    public void DamagePlayer( int damage )
    {
        curHealth -= damage;

        healthBar.SetHealth( curHealth );
    }

    
  void OnTriggerEnter(Collider other){
     if(other.CompareTag("enemy")) {
         DamagePlayer(10);
        healthBar.SetHealth( curHealth );
        Destroy(other.gameObject);
     }
  }
}
