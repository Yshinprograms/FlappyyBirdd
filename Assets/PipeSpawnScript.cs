//Create prefabs by dragging them from hierarchy to assets

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inherited PipeMoveScript, so already has the move left attribute
public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    //spawnRate = how many seconds in between each pipe spawn
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {

        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
            //As mentioned, Time.deltatime is 1 unit/second
        }
        else
        {
            spawnPipe();
            //Instantiate clones our object(pipe)
            //transform.position clones the object in the same place
            //transform.rotation clones the object in the same orientation
            timer = 0;
        }

    }
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, (Random.Range(lowestPoint, highestPoint)), 0), transform.rotation);
        //Random.Range(minInclusive, maxInclusive) returns a random float/int btw min and max
        //So in this case we create a new 3d vector 
        //Fix x to be the same
        //Randomly generate a y value between the lowest and highest point on the map
        //Fix z to be the same
        //Fix the orientation of the pipes
    }
}
