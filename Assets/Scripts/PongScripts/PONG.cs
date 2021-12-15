using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PONG : MonoBehaviour
{
    public static PONG obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnOffPong() 
    {
        MainCamera.obj.SetGametwoCamera();

        this.gameObject.SetActive(false);
        Debug.Log("andaaa!!!");
    }
}
