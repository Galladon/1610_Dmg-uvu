using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroKill : MonoBehaviour
{
//    void OnTriggerEnter2D(Collider2D other){
//        if(other.name == "Hero"){
//            Destroy(other);
//        }
//    }
public LevelManager gameManager;
void start (){
    gameManager = FindObjectOfType <LevelManager>();

}
void OnTriggerEnter2D(Collider2D other){
    if(other.name == "Hero"){
        gameManager.RespawnPlayer();
    }
}
}
