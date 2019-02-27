using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    
    public string suspect;
    public string room;

    
    // Start is called before the first frame update
    void Start()
    { MurderMystery(suspect);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void MurderMystery(string suspect){
    switch(suspect){
        //case "Tim Curry":
       // print("I was in the study with the maid");
       // break;
        //cases need : and you can use diffrent data types... you need to add in breaks in between the cases
        // you can set up a fallthrough by doing case(enter)case, and applying them both to the same data.
        case "Tim Curry":
        case "maid":
        print( "I was in the study !");
        break;
        case "Mrs. White":
        print("I did that schmuck in!");
        break;
        case "cook":
        print("(ghost cook) I was killed first!");
        break;
        default:
        print(""+suspect+"is not a suspect! ");
        break;
    }
    }
}

