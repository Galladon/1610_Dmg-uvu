using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour{

    public string stoplight;
    public bool isUtahn = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        if(stoplight == "red" && isUtahn){

        //code that gets run on conditions being met
         
            if(isUtahn){
                print("the light is red!");


            }   
            else{
                print("Thanks for stopping!");
            }
        }
        else if(stoplight == "yellow"){
            if(isUtahn){
            print("if you're wheels make it in you're clean, so speed up!");
            }

            else {
                print("prepare to stop!");
            }
    
        }
        else if(stoplight == "green"){
            print(" feel free to speed more!");
        }
        else{
            print("sorry for your loss, you're driving in hell");
        }
    }
}
