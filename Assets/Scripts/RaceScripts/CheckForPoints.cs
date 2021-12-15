using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForPoints : MonoBehaviour
{
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
            Time.obj.score += 500;

        }
        
    }

}
