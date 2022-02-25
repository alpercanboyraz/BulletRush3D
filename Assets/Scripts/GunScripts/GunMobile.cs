using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMobile : MonoBehaviour
{
    
    [SerializeField] private float rangePlayer;
    private GameObject player; 
    private GameObject gun;  
    Animator anim;
    private float accuracy;
 
    public float maxSpreadAngle;
 
    public float timeTillMaxSpread;
 
    public GameObject bullet;
 
    public GameObject shootPoint;
    public float range = 10f;
 
        void Start(){

        player = GameObject.FindGameObjectWithTag("Player");
        anim = player.GetComponent<Animator>();

    }

    void Update()
    {
       
         //accuracy += Time.deltaTime * 4f;
         if(Vector3.Distance(player.transform.position,transform.position) <= rangePlayer){
            anim.SetBool("isFire",true);
            Shoot();
            }
        }
 
    void Shoot()
    {
        RaycastHit hit;
 
        Quaternion fireRotation = Quaternion.LookRotation(transform.forward); // raycast'in bakıcağı yön
 
        float currentSpread = Mathf.Lerp(0.0f, maxSpreadAngle, accuracy / timeTillMaxSpread);
 
        fireRotation = Quaternion.RotateTowards(fireRotation, Random.rotation, Random.Range(0.0f, currentSpread));
 
        if (Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit,range))
        {
            
             if(hit.collider.gameObject.tag == "smallEnemy" || hit.collider.gameObject.tag == "bigEnemy"){
                 //Destroy(hit.collider.gameObject);
                 GameObject tempBullet = Instantiate(bullet, shootPoint.transform.position, fireRotation);
                 tempBullet.GetComponent<Bullet>().hitPoint = hit.point;
            }    
        }
    }
}
