using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class herojumpweeklyscript : MonoBehaviour
{ public float jumpspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.W)){
             GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpspeed);
        }
       
    }
}
