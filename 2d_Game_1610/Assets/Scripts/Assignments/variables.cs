using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour{
// variables
public int number;
public float speed;
public string name;
    // Start is called before the first frame update
    void Start() {
        /*
        This
        Is 
        A
        Multy
        Line
        Comment
        Example
         */
      number = 10; 
      speed = 0.141f;  
      name = "galladon";

      print(name + " is "+number+" years old "+ speed);
    }

    // Update is called once per frame
    void Update() {
     transform.position=new Vector3( number,0,0);
    }
}
