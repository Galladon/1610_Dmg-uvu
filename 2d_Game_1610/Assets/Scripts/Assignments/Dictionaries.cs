using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionaries : MonoBehaviour
{
    public Hashtable sprenDetails = new Hashtable();
    // Start is called before the first frame update
    void Start()
    { sprenDetails.Add("Type", "Honor Spren");
      sprenDetails.Add("Name", "Syl");
      sprenDetails.Add("Bonded to", "Kaladin" );
      sprenDetails.Add("Gender", "Female");
      sprenDetails.Add("Weapon Type", "Syl Spear");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
