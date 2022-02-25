using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerManager : MonoBehaviour
{
    public Animator anim;
    public GameObject failedScreen;
    void Start()
    {
       anim = gameObject.GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision){
        
            if(collision.gameObject.tag == "smallEnemy" || collision.gameObject.tag == "bigEnemy"){
            anim.SetBool("isDie",true);
            failedScreen.SetActive(true);
        }
    }

}
