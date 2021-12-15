using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] Car car;

    public bool inGround;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var car = collision.gameObject.GetComponent<Car>();

        if (car != null)
        {
            inGround = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inGround = false;
    }
}
