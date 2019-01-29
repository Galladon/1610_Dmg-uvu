using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public int Waterbottle = 60;
    // Start is called before the first frame update
    void Start()
    {
        print(Waterbottle);
        Debug.Log(Waterbottle);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Waterbottle -= 1);

    }
}
