using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : HeroHP
{
   void OnTriggerEnter2D(Collider2D other){
         if(other.name == "Hero"){
             GetHurt(25);

         }
          
}
}
//this so far has only been taking down the enemys hp, not the players.