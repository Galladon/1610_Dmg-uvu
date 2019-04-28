using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour{
    // Start is called before the first frame update
  public int coinValue;
  public LevelManager LevelManager;
  public float xValue;
  public float yValue;

     //piutting in colider for coin
     void OnTriggerEnter2D(Collider2D other){
         if(other.name == "Hero"){
            
            LevelManager.SetSpawn(xValue, yValue);

            Scoremanager.AddPoints(coinValue);

            Destroy(gameObject);
         }
     }
}
