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
    public void RespawnPlayer(){
        StartCoroutine ( "RespawnPlayerCo");
    }
    public IEnumerator RespawnPlayerCo(){
        //death particles
        Instantiate( deathParticle, pcRigid.transform.position, pcRigid.transform.rotation );
        player.SetActive(false);
        player.GetComponent<Renderer> ().enabled = false;
        //Gravity Reset
        gravityStore = pcRigid.GetComponent<Rigidbody2D>().gravityScale;
        pcRigid.GetComponent<Rigidbody2D>().gravityScale = 0f;
        pcRigid.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        //point penalty
        Scoremanager.AddPoints(- pointPenaltyOnDeath);
        //debug manager
        Debug.Log ("Hero Respawn");
        //respawn delay
        yield return new WaitForSeconds (respawnDelay);
        //gravity restore
        pcRigid.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
        //match hero's transform position
        pcRigid.transform.position = currentCheckPoint.transform.position;
        //Show PC
        player.SetActive(true);
        player.GetComponent<Renderer>(). enabled = true;
        Instantiate (respawnParticle, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
