using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour{
    public int coinValue;
     //piutting in colider for coin
     void OnTriggerEnter2D(Collider2D other){
         if(other.name == "Hero"){
              print("you've collected a flower! ");

              Destroy(gameObject);

         }

     }
}
