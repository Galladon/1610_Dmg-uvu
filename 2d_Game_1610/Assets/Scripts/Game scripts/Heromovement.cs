﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heromovement : MonoBehaviour {

    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.D)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        
        else if(Input.GetKeyDown(KeyCode.A)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        
    }
}
