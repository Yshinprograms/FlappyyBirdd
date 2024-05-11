using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//UI is another game object, but we need to import the UI class
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    //Init an internal count for player's score
    public Text scoreText;
    //Adds a variable slot to the inspector menu
    //We can drag and drop UI text into the slot
    //then it fills up the scoreText variable in the script
    public GameObject gameOverScreen;
    public bool birdIsAlive = true;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        //Keep track of players score internally
        //Not assigned to UI text yet
        scoreText.text = playerScore.ToString();
        //Converts internal count(integer) to string
        //Then assign to scoreText
        //Needs scoreText.text because Text is a class in Unity
        //of which .text is only one of the properties
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        /* 1. SceneManager.GetActiveScene() gets a reference to the scene currently loaded and running
         * 2. SceneManager.GetActiveScene().name extracts the name of the active scene
         * 3. SceneManager.LoadScene loads scene that matches name
         * which in this case is the currently running scene, basically resetting level
         */

    }

    public void gameOver()
    {
        birdIsAlive = false;
        gameOverScreen.SetActive(true);
        /* Triggers when bird crashes into pipe
         * we call this in BirdScript
         * 
         */
    }
}
