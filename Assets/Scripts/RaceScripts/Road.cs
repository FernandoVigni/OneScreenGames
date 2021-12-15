using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField] int moveDown;
    [SerializeField] Ground Ground;
    public float speedMode;

    public float diferenceToTop;

    // Update is called once per frame
    void Update()
    {

        if (Ground.inGround)
            RoadMovingSlowMotion();
        else
            RoadMoving();
    }

    public void RoadMoving() 
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - (moveDown * 0.10f), transform.position.z);
    }

    public void RoadMovingSlowMotion()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - (moveDown * 0.10f) / 2, transform.position.z);
    }

    public void RoadToTop()
    {
        transform.position = new Vector3(transform.position.x , transform.position.y + diferenceToTop, transform.position.z);
    }
}
