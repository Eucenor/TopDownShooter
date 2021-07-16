using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float rateOfFire = 1;
    [SerializeField] private Transform emitter;
    private float NextFire = 0;
    private void Update(){
        
        if(Input.GetKey(KeyCode.Mouse0) && Time.time>= NextFire)
        {
             GameObject.Instantiate(bullet,emitter.position,emitter.rotation);
             NextFire = Time.time + 1/rateOfFire;
        }
    }
    
}
