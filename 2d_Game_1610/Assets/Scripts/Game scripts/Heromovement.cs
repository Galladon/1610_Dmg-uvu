using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heromovement : MonoBehaviour {

// movement varriables

    public float moveSpeed;
    public float jumpspeed;
    // jump requierments
    public Transform groundCheck;
    public float groundCheckRadius;
    private bool grounded;
    public LayerMask whatIsGround;

    // Start is called before the first frame update
    void Start()
    {   //need to refine, default true.    
        
        
    }
    void Fixedupdate(){
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    // Update is called once per frame
    
    //player movement left/right
    void Update(){
        if(Input.GetKey(KeyCode.D)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        
        else if(Input.GetKey(KeyCode.A)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        //player jump
        if(Input.GetKeyDown(KeyCode.W) && grounded){
            Jump();
        
        }
        
    }
void Jump(){
    
             GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpspeed);

    
}

}
