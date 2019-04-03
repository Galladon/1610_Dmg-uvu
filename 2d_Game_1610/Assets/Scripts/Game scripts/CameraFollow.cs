using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Heromovement hero;
    public bool isFollowing;
    public float xOffset;
    public float yOffset;
    // Start is called before the first frame update
    void Start(){
        hero = FindObjectOfType<Heromovement>();
        isFollowing = true;

        
    }

    // Update is called once per frame
    void Update(){
        if(!isFollowing){
            transform.position = new Vector3(hero.transform.position.x + xOffset, hero.transform.position.y +yOffset, transform.position.z);
        }
        
    }
}
