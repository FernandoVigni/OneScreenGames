using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public static MainCamera obj;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetGameOneCamera() 
    {
        //setear la camara en el game 1 q es  Transform 0/0
        transform.position = new Vector3(0, 0, 0);
    }

    public void SetGametwoCamera()
    {
        //setear la camara en el game 2
        transform.position = new Vector3(30, 0, 0);
    }

    public void SetGamethreeCamera()
    {
        //setear la camara en el game 3
        
    }
    public void SetGameforeCamera()
    {
        //setear la camara en el game 4
    }
}
