﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroShoot : MonoBehaviour{
    public Transform firePoint;
    public GameObject projectile;
    // Start is called before the first frame update
    void Start(){
        projectile = Resources.Load("Prefabs/Projectile") as GameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
            Instantiate(projectile,firePoint.position, firePoint.rotation);
        
    }
}
