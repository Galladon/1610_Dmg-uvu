using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour{
    public float speed;
    public float timeOut;
    public GameObject hero;
    public GameObject enemyDeath;
    public GameObject projectileParticle;
    public int pointsForKill;
    // Start is called before the first frame update
    void Start(){
        //initializes object
        hero = GameObject.Find("Hero");
        enemyDeath = Resources.Load("Prefabs/Death_PS") as GameObject;
        projectileParticle = Resources.Load("Prefabs/Respawn_PS") as GameObject;
        if(hero.transform.localScale.x < 0)
            speed = -speed;
        Destroy(gameObject, timeOut);
    }

    // Update is called once per frame
    void Update(){
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);

        
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Enemy"){
            Instantiate(enemyDeath, other.transform.position, other.transform.rotation);
            Destroy( other.gameObject);
            Scoremanager.AddPoints (pointsForKill);

        }//Instantiate(projectileParticle, transform.position transform.rotation);
        Destroy(gameObject);
    }
    void OnCollisionEnter(Collider2D other){
        Instantiate(projectileParticle, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
