using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{
    public int levelToLoad;
    //index for scenes
    public void LoadLevel(){
        SceneManager.LoadScene(levelToLoad);
        //loads the level after the button is pressed

    }
    public void LevelExit(){
        Application.Quit();
    }
    //Quits the game after you hit the button
}
