using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public int test;

    void Start() //runs precisely once
    {
        gameObject.name = "Lil Birdy";
    }


    void Update() //runs constantly while script is enabled
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            //Vector2 is a shortcut that gives the vector (0,1), which is 1 unit in the up direction
            //We multiply by 10 to give the flap more power
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }
}
