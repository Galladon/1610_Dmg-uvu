using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheckPoint;
     private Rigidbody2D pcRigid;

    private GameObject player;
    // particles
    public GameObject deathParticle;
    public GameObject respawnParticle;

    //respawn delay
    public float respawnDelay;

    //point penalty
    public int pointPenaltyOnDeath;
    private float gravityStore;
    // Start is called before the first frame update
    void Start()
    {
        pcRigid = GameObject.Find("Hero").GetComponent<Rigidbody2D>();
        player = GameObject.Find("Hero");
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
