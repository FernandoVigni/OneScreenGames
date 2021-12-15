using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCar : MonoBehaviour
{

    private Rigidbody2D rb;
    public int speed;

    public float cuantoValeX;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        TruckGoDown();
        transform.position = new Vector3(27.1f, transform.position.y, transform.position.z);
        cuantoValeX = transform.position.x;
    }

    public void TruckGoDown() 
    {
        rb.velocity = new Vector2(rb.velocity.x, speed * -1);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var car = collision.gameObject.GetComponent<Car>();

        //si el auto esta por la derecha
        if(car.gameObject.transform.position.x > transform.position.x)
        {
            Car.obj.rb.velocity = new Vector2(2, rb.velocity.y); 
        }
        
    }


}
