using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Pickup : Baisic_Pickup
{
    public GameObject hero;




    void OnTriggerEnter2D(Collider2D other){
        if(GameObject.other.name == "hero"){
            //player collect coin
        }
        else{
            //not player
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
