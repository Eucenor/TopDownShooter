using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float rateOfFire = 3;
    [SerializeField] private Transform emitter;
    [SerializeField] private EnemyMovement movement;
    private float NextFire = 0;
    private void Update(){
        
        if(  Time.time>= NextFire)
        {   print("yes");
             GameObject.Instantiate(bullet,emitter.position,emitter.rotation);
             NextFire = Time.time + 1/rateOfFire;
        }
        
    }
}
