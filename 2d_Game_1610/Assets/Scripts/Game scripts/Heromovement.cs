using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heromovement : MonoBehaviour {

// movement varriables

    public float moveSpeed;
    public float jumpSpeed;
    // jump requierments
    public Transform groundCheck;
    public float groundCheckRadius;
    private bool grounded;
    private bool doubleJump;
    
    public LayerMask whatIsGround;
    private float moveVelocity;
    //public Animator animator; 
    
    // Start is called before the first frame update
    void Start()
    {   //Resets animation    
        // animator.SetBool("Hero_Run", false);
        // animator.SetBool("Hero_Jump", false);
        // animator = GetComponent<Animator>();
    }
    void FixedUpdate(){
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    // Update is called once per frame
    
    //player movement left/right
    void Update(){
        if(Input.GetKey(KeyCode.D)){
            moveVelocity = moveSpeed;
            // animator.SetBool("Hero_Run", true);
             GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else if(Input.GetKeyUp(KeyCode.D)){
            // animator.SetBool("Hero_Run", false);
        }
        
         if(Input.GetKey(KeyCode.A)){
            moveVelocity = -moveSpeed;
            // animator.SetBool("Hero_Run", true); 
             GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
         }
        
           
        else if(Input.GetKeyUp (KeyCode.A)){
            // animator.SetBool("Hero_Run", false);
        
        }

        
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);
       
        //player jump
        if(Input.GetKeyDown(KeyCode.W) && grounded){
            Jump();
        
        }
        //DoubleJump
        if(grounded){
            doubleJump = false;
            // animator.SetBool("Hero_Jump", false);
        }

        if(Input.GetKeyDown( KeyCode.W)&& !doubleJump && !grounded){
            Jump();
            doubleJump = true;
            // animator.SetBool("Hero_Jump", true);
        }
         moveVelocity = 0f;
        
        //Player Flip
        if(GetComponent<Rigidbody2D>().velocity.x>0)
            transform.localScale = new Vector3(4f,4f,2f);

        else if (GetComponent<Rigidbody2D>().velocity.x < 0)
        transform.localScale = new Vector3(-4f,4f,2f);
    } 
   
void Jump(){
    
             GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpSpeed);
                // animator.SetBool("Hero_Jump", true);
    
}

}
