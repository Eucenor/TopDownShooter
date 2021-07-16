using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
   [SerializeField] private float bulletspeed = 100;
   [SerializeField] private float lifeTime = 10f;
    void Awake()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        body.velocity = transform.forward *bulletspeed;
        lifeTime = Time.time + lifeTime;
    }
    void Update(){
        if(Time.time>lifeTime){
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag != "muzzle")
        {   
            Destroy(this.gameObject);
            
        }
    }

}
