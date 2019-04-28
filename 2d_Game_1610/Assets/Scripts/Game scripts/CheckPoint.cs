using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour{
    // Start is called before the first frame update
  public int coinValue;
  

     //piutting in colider for coin
     void OnTriggerEnter2D(Collider2D other){
         if(other.name == "Hero"){
            


                Scoremanager.AddPoints(coinValue);

              Destroy(gameObject);
         }
     }
}
