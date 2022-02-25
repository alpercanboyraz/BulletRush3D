using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Bullet : MonoBehaviour
{
     public Vector3 hitPoint;
 
     //public UnityEvent HealthControl;
 
     public int speed;
 
     
  
    void Start()
    {
        this.GetComponent<Rigidbody>().AddForce((hitPoint - this.transform.position).normalized * speed);
    }
 
    
   void OnCollisionEnter(Collision col)
    {
        
        Destroy(this.gameObject,2f);
        
        if (col.gameObject.tag == "smallEnemy" || col.gameObject.tag == "bigEnemy") 
        {
          col.gameObject.GetComponent<Health>().HealthControl(); // enemynin health classından ne kadar canı kaldığını kontrol eder
        }
        
    }
}
