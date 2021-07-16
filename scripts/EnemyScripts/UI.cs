using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private Image image;
   private void Awake(){
       image.fillAmount = 1;
   }

    // Update is called once per frame
    void Update()
    {
        
        if(image.fillAmount <=0){
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "bullet"){
          image.fillAmount -= 0.1f;  
        }
    }
}
