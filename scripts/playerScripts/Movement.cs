using UnityEngine;

public class Movement : MonoBehaviour
{
    /*is zero if horizontal axis(s or d or left or right arrow keys) are not pressed. -1 if left,s key is pressed 1
     if right arrow key is pressed*/
    private float left = 0;
    //same af left but for vertical axis
    private float up = 0;
    //speed of the player per second
    [SerializeField] private float speed = 100f;
    //rigidbody of the player to move it in the world. Used the velocity attribute in it for movement
    [SerializeField] private Rigidbody playerbody;
    // camera that looks at the player. used to calculate where the player should look at.
    // muzzle of the player attached to body


    
    private void Awake(){
        //if rigidbody is not assigned from outside of script then assign from here
        if(!playerbody)
            playerbody = GetComponent<Rigidbody>();
        //simply the main camera in the scene
        //same for muzzle. get its transform if not assigned from outside the script
        

    }
    void Update()
    {
        //function to take left and up values
        DirectionInputs();
    
    }
    private void FixedUpdate(){
        //function to make the player look at mouse 

        MovePlayer();
        
    }
    private void MovePlayer(){
        playerbody.velocity = transform.forward * up * Time.fixedDeltaTime * speed;
        print(transform.forward * up * Time.fixedDeltaTime * speed);        
    }
    private void DirectionInputs(){
        left = Input.GetAxis("Horizontal");
        up = Input.GetAxis("Vertical");
    }
    
}
