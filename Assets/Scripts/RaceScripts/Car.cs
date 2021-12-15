using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public static Car obj;

    public float movHor;
 
    public float speed;
    public Rigidbody2D rb;
    public int timeToRestart;
    public float newXPosition;
    bool freez;

    private void Awake()
    {
        obj = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (freez)
            Freez();

        movHor = Input.GetAxisRaw("Horizontal");

        DriveCarHorizontal();
    }

    public void DriveCarHorizontal() 
    {
        rb.velocity = new Vector2(movHor * speed, rb.velocity.y);
        centrateCar();
    }

    private void centrateCar() 
    {
        if(transform.position.x < 26.6f)
        {
            transform.position = new Vector3(26.6f, transform.position.y, transform.position.z);
        }

        if (transform.position.x > 34.3f)
        {
            transform.position = new Vector3(34.3f, transform.position.y, transform.position.z);
        }
    }

    public void Restart() 
    {
        timeToRestart = 3;
        transform.position = new Vector3(29, -2, transform.position.z);
    }

    public void TimeToRestart() 
    {
        timeToRestart--;
        if (timeToRestart < 0)
            timeToRestart = 0;
        Restart();
    }

    public void SaveFreezPosition() 
    {
        newXPosition = transform.position.x;
        freez = true;
    }

    public void Freez() 
    {
        transform.position = new Vector3(newXPosition, transform.position.y, transform.position.z);
    }
}
