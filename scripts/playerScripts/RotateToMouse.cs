using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMouse : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Plane floor = new Plane(Vector3.up,transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float len;
        if(floor.Raycast(ray,out len)){
            Vector3 point  = ray.GetPoint(len);
            transform.LookAt(point);
        }
        
    }
}
