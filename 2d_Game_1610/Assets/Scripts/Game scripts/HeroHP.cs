using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroHP : MonoBehaviour

{
    public float heroHP = 100; 
    public Slider healthBar;
    public float currentHP;
    

    // Start is called before the first frame update
    void Start(){ 
        currentHP = heroHP;
    }

    // Update is called once per frame
    public void GetHurt(float damage){
      currentHP -= damage;
        healthBar.value = currentHP; // Error Is Here

    }
}
  