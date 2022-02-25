using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    [SerializeField] private int currentHealth;    
     public bool smallDeadEnemy,bigDeadEnemy;
    public void HealthControl(){

        if(currentHealth > 0) {
            currentHealth -= 100;
        }
        if(currentHealth == 0){
           
            Destroy(gameObject);
        }
    }
}
