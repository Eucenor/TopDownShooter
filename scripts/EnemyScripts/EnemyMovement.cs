using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float fireDistance;
    [SerializeField] private float retreatDistance;
    [SerializeField] private Transform player;
    [SerializeField] private Rigidbody body;
    [SerializeField] private float speed  = 100f;
    [SerializeField] private NavMeshAgent navigator;
    void Awake()
    {
        fireDistance = 7f;
        retreatDistance = 3f;
        if(!player){
            player = GameObject.Find("player").GetComponent<Transform>();
        }
        if(!body){
            body = GetComponent<Rigidbody>();
        }
        if(!navigator){
            navigator = GetComponent<NavMeshAgent>();
        }
    }
    void Update()
    {
        transform.LookAt(player);
    }
    private void FixedUpdate(){
        if(!IsInsideFiringZone()){
            navigator.SetDestination(player.position);
        }
    }
    public bool IsInsideFiringZone(){
        return (player.position - transform.position).magnitude <= fireDistance;
    }
    public bool IsInsideRetreatZone(){
        return (player.position - transform.position).magnitude < retreatDistance;
    }
    
}
