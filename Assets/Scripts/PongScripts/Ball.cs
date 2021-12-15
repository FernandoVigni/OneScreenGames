using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;

    public int pointsOfPlayer1;
    public int pointsOfPlayer2;
    public Vector2 VelocityBall;

    private void Awake()
    {
        Provider.Ball = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SetBall();
    }

    private void LateUpdate()
    {
        rb.velocity = VelocityBall;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<Player>();
        var player2 = collision.gameObject.GetComponent<Player2>();
        var wall = collision.gameObject.GetComponent<Wall>();
        var goal = collision.gameObject.GetComponent<Goal>();
        var goal2 = collision.gameObject.GetComponent<Goal2>();

        if (player != null || player2 != null)
        {
            VelocityBall = new Vector2(VelocityBall.x * -1, VelocityBall.y);
            Debug.Log("golpee a un player");
        }
        if (wall != null)
        {
            VelocityBall = new Vector2(VelocityBall.x, VelocityBall.y * -1);
               Debug.Log("golpee a una pared");
        }
        if (goal != null)
        {
            transform.position = new Vector3(0, 0, 0);
            pointsOfPlayer2++;
            UIManager.obj.UpdatePoints(1);   
        }
        if (goal2 != null)
        {
            transform.position = new Vector3(0, 0, 0);
            pointsOfPlayer1++;
            UIManager.obj.UpdatePoints(2);
        }
    }

    public void SetBall() 
    {
        int setX = 2;
        int setY = 2;
        VelocityBall = new Vector2(setX, setY);
    }
}
