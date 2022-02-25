using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAI : MonoBehaviour
{
   [SerializeField] private NavMeshAgent enemy;
    private GameObject player;

  void Start(){
      player = GameObject.FindGameObjectWithTag("Player");
  }
   void Update(){

       enemy.SetDestination(player.transform.position);
   
   }
}
