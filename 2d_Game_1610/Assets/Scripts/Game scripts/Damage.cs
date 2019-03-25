using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : HeroHP
{
   void OnTriggerEnter2D(Collider2D other){
         if(other.name == "Hero"){
             print("Ouch!");

         }
         if(other.name == "Hero"){ 
             if( currentHP > 1){
                 currentHP = currentHP - 1;
             }
         }
}
}
//this so far has only been taking down the enemys hp, not the players.