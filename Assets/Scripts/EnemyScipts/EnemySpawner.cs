using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
public class EnemySpawner : MonoBehaviour
{
   
  [Header("Enemy Objects")]
   
   private float xPos=-7f; //  enemy doğacağı  ilk x noktası
  
   [SerializeField] public int smallEnemyCount;
   [SerializeField] public int bigEnemyCount;
    
   [SerializeField] private GameObject smallEnemy; 
   [SerializeField] private GameObject bigEnemy;
  
  void Awake(){
       
       EnemySpawn();
       smallEnemy.transform.localScale = new Vector3(1f,1f,1f);
       bigEnemy.transform.localScale = new Vector3(1f,1f,1f);
    }
    
   public void EnemySpawn(){
       
        Vector3 scaleChange = new Vector3(1f, 1f, 1f); // small enemy scale
        
        for (int i = 0; i < smallEnemyCount; i++)
        {
          
          smallEnemy.transform.localScale += scaleChange;
          Instantiate(smallEnemy,new Vector3(xPos,-7.934f,6f),Quaternion.identity);
          smallEnemy.transform.localScale -= scaleChange;
          xPos += 3; // enemy'lerin yan yana hizalı bir şekilde doğması için 
            
        }    
        
        scaleChange = new Vector3(1.5f, 1.5f, 1.5f); // big enemy scale
        xPos = -7f;
        
        for (int i = 0; i < bigEnemyCount; i++)
        {
            
           
            bigEnemy.transform.localScale += scaleChange;
            Instantiate(bigEnemy,new Vector3(xPos,-7.934f,27f),Quaternion.identity);
            bigEnemy.transform.localScale -= scaleChange;
            xPos += 4;
       
        }
    
    }

   
}