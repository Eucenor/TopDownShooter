using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{   
    [SerializeField] private Image image;
    [SerializeField] private float health = 1f;
    [SerializeField] private float damage = 0.2f;
       void Start()
    {
        image.fillAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(health<=0){
            Destroy(this.gameObject); 
        }
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "bullet"){
            health -= damage;
            image.fillAmount = health;
            print(health);
        }
    }
}
