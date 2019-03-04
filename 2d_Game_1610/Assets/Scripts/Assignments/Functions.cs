using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour{
    void Start(){
        print(Sum(60,9));
        print(Multi(5,25));
    }
    public string weather;
    //void Start(){ 
        //Weather(weather);
   // }
   //void Weather(string weatherstate){

       //if(weatherstate == "sunny"){
           //print("The sun is shining'");
        
     //  }
       //else if(weatherstate == "raining"){
         //  print("it is damp and gloomy today");

       //}
      // else if(weatherstate == "snowing"){
          // print("it is freezing and slick today");
           
       
       //}
         //else if(weatherstate == "windy"){
           //print("it is blustrey today");
      // }
        // else if(weatherstate == "foggy"){
          // print("it is difficult to see today");
            //}
    
   

   //int is a valid function type
   int Sum( int a, int b){
       return a + b;
   
   }
   int Multi( int c, int d){
       return c * d;
   }
   }


      

