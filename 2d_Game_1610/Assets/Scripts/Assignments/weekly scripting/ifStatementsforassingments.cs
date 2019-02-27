using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifStatementsforassingments : MonoBehaviour{
    public string fruitPreference;

    // Update is called once per frame
    void Update(){
        if(fruitPreference == "apples"){
            print("which type of apples?");
        }
        
        else if(fruitPreference == "red apples"){
            print("I enjoy nice and crips ones!");
        }
        else if(fruitPreference == "green apples"){
            print("i really only like them in pies and carmel appels");
        }
        else if(fruitPreference == "blueberries" ){
            print( "tasty!");
        }
    }
}
