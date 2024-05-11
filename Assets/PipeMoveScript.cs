using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float movespeed = 7;
    public float deadzone = -40;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;
        //We use Vector3 here because Unity is a 3D game engine
        //so our objects are actually in 3D space despite making 2D games
        //Time.deltaTime ensures that we move at 1 unit per second instead since
        //the game would render 1 unit per frame --> 1000 units per second if 1000fps

        if (transform.position.x < deadzone)
        {
            Debug.Log("Pipe deleted");
            Destroy(gameObject);
        }
    }
}
