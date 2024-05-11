using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public int test;
    public LogicScript logic;

    void Start() //runs precisely once
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        gameObject.name = "Lil Birdy";
    }


    void Update() //runs constantly while script is enabled
    {
        if (Input.GetKeyDown(KeyCode.Space) && logic.birdIsAlive)
        {
            //Vector2 is a shortcut that gives the vector (0,1), which is 1 unit in the up direction
            //We multiply by 10 to give the flap more power
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

        if (transform.position.y <= -21)
        {
            logic.gameOver();
        }
        //We use onCollision instead of onTrigger because the pipes now are solid objects

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
    }
}
