using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//UI is another game object, but we need to import the UI class

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    //Init an internal count for player's score
    public Text scoreText;
    //Adds a variable slot to the inspector menu
    //We can drag and drop UI text into the slot
    //then it fills up the scoreText variable in the script

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
}
