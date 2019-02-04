using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignmetvariables : MonoBehaviour
{
    public string pkmtype;
    public int preferance;

    // Start is called before the first frame update
    void Start(){
        if(pkmtype == "electric"){
            print("My favorite #"+preferance);
            preferance = 2;
            
        }
    }


    
}
