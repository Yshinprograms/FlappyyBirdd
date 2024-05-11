using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//When we want to reference a game object when it is not in the scene
//we need to find that component during runtime as shown below

public class MiddlePipeScript : MonoBehaviour
{
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        //This does the same thing as dragging and dropping an object
        //into the variable slot except that this is executed during runtime
        //This allows this script to talk to LogicScript by using Logic as the imported class

        /*Basically, this is how we find the class/script that we want:
         * 1. Find a gameObject with the tag "Logic"
         * 2. Get the component of type <LogicScript> that is attached to the gameObject
         * 3. Store a reference to the LogicScript in the logic variable of this script
         * The function or variable from the other script we want to use must be public
         */
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //This tracks the layer of the specific gameObject that triggered the collision
        //NOT the middle pipe
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
    }
}
