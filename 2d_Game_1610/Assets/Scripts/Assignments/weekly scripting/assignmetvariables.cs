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
            print("My favorite type! #"+preferance);
            preferance = 1;
            
        }
        else if(pkmtype == "dragon"){
            print("Its so close to my favorite, but its #"+preferance);
            preferance = 2;
        }
        else if(pkmtype == "ice"){
            print("They're sooo cool, i love them a lot! #"+ preferance);
            preferance = 3;
        }
        else if(pkmtype == "grass"){
            print("I love a lot of these pokemon, but i prefer other types #"+preferance);
            preferance = 4;
        }
        else if(pkmtype == "water"){
            print("I like some of these pokemon, but i think they are allright #"+preferance);
            preferance = 5;
        }
        else{
            print("I'm not a huge fan of that type of pokemon");
    }
    


    
}

}
