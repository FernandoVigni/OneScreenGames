using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    Rigidbody2D rb;
    public bool goingUp;
    public bool goingDawn;
    public float speed;
    public float movVertical;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2 (rb.velocity.x, movVertical * speed);
        RightButonListener();
    }

    public void RightButonListener()
    {
        if (Input.GetKeyDown("d"))
            movVertical = movVertical * -1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
    }
}